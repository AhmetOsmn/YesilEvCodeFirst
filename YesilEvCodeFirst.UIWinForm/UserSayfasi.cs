using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.ProductFavList;
using YesilEvCodeFirst.DTOs.SearchHistory;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.DTOs.Supplier;
using YesilEvCodeFirst.DTOs.UserAdmin;
using YesilEvCodeFirst.DTOs.UserFavList;

namespace YesilEvCodeFirst.UIWinForm
{

    public partial class UserSayfasi : Form
    {

        bool isProductSupplementOpen = false;
        bool isAddProduct = true;
        bool isUpdatable = false;
        bool sideBarExpand = false;

        GetProductDetailDTO dto = null;
        GetProductDetailDTO selectedProduct = null;
        FavListDTO selectedFavList = null;
        AddProductFavListDTO addProductFavListDTO = null;

        public UserDetailDTO User;
        readonly UseSupplierDAL useSupplierDAL = new UseSupplierDAL();
        readonly UseCategoryDAL useCategoryDAL = new UseCategoryDAL();
        readonly UseProductDAL useProductDAL = new UseProductDAL();
        readonly UseSearchHistoryDAL useSearchHistoryDAL = new UseSearchHistoryDAL();
        readonly UseFavListDAL useFavListDAL = new UseFavListDAL();
        readonly UseProductFavListDAL useProductFavListDAL = new UseProductFavListDAL();
        readonly UseBlackListDAL useBlackListDAL = new UseBlackListDAL();
        readonly UseSupplementBlackListDAL useSupplementBlackListDAL = new UseSupplementBlackListDAL();
        readonly UseProductSupplementDAL useProductSupplementDAL = new UseProductSupplementDAL();
        readonly UseUserDAL useUserDAL = new UseUserDAL();

        public UserSayfasi()
        {
            InitializeComponent();
            CloseAllPages();
            GetAddAndUpdateProductCategoriesAndSuppliers();
            Home.Visible = true;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                CloseSideBar();
            }
            else
            {
                OpenSideBar();
            }
        }
        private void OpenSideBar()
        {
            foreach (Panel item in SideBar.Controls)
            {
                if (item.Name == "pnlSideBarHome" || item.Name == "pnlSideBarMenu")
                {
                }
                else
                {
                    item.Width = 190;
                    item.Visible = true;
                }
            }
            sideBarExpand = true;
            SideBar.Width = SideBar.MaximumSize.Width;
            SideBar.Height = SideBar.MaximumSize.Height;
        }
        private void CloseSideBar()
        {
            foreach (Panel item in SideBar.Controls)
            {

                if (item.Name == "pnlSideBarHome" || item.Name == "pnlSideBarMenu")
                {
                    pnlSideBarYesilEv.Width = 10;
                    pnlSideBarGiveStarApplication.Width = 10;
                }
                else
                {
                    item.Width = 0;
                    item.Visible = false;
                }
            }
            sideBarExpand = false;
            SideBar.Width = SideBar.MinimumSize.Width;
            SideBar.Height = SideBar.MinimumSize.Height;
        }
        private void Home_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            Home.Visible = true;
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            grpBoxAddAndUpdateProductAddProduct.Visible = false;
            isAddProduct = false;
            btnAddAndUpdateProductUpdateProduct.BackColor = Color.DarkGreen;
            grpBoxAddAndUpdateProductUpdateProduct.Visible = true;
            btnAddAndUpdateProductAddProduct.BackColor = Color.Green;
            CleanAddAndUpdateProduct();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            grpBoxAddAndUpdateProductUpdateProduct.Visible = false;
            isAddProduct = true;
            isUpdatable = false;
            btnAddAndUpdateProductAddProduct.BackColor = Color.DarkGreen;
            grpBoxAddAndUpdateProductAddProduct.Visible = true;
            btnAddAndUpdateProductUpdateProduct.BackColor = Color.Green;
            CleanAddAndUpdateProduct();
        }

        private void AddAndUpdateProduct_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            AddAndUpdateProduct.Visible = true;
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            UserDetails.Visible = true;
            lblUserDetailsSignUpDateValue.Text = User.CreatedDate.ToString();
            lblUserDetailsUserName.Text = User.FirstName + " " + User.LastName;
            lblUserDetailsAddProductCount.Text = useProductDAL.GetProductListWithUserID(User.UserID).Count.ToString();
        }

        private void AddAndUpdateProductBtnSend_Click(object sender, EventArgs e)
        {
            btnAddAndUpdateProductSend.Enabled = false;
            UseProductDAL dal = new UseProductDAL();
            if (isAddProduct)
            {
                if (isAddProductFieldValidator())
                {
                    bool result = dal.AddProduct(new AddProductDTO
                    {
                        AddedBy = User.UserID,
                        Barcode = txtAddAndUpdateProductAddProductBarcodeNo.Text,
                        SupplierID = ((SupplierDTO)cmbBoxAddAndUpdateProductAddProductSupplier.SelectedItem).SupplierID,
                        ProductName = txtAddAndUpdateProductAddProductProductName.Text,
                        CategoryID = ((CategoryDTO)cmbBoxAddAndUpdateProductAddProductCategory.SelectedItem).CategoryID,
                        ProductContent = txtAddAndUpdateProductAddProductProductContext.Text,
                        //to do file dialog get path
                        PictureFronthPath = FileDialogAddProductFront.FileName,
                        PictureBackPath = FileDialogAddProductBack.FileName,
                    });
                    if (result)
                    {
                        MessageBox.Show("Ürün Eklendi");
                        CloseAllPages();
                        int lastAddedProductID = useProductDAL.GetProductDetailWithBarcode(txtAddAndUpdateProductAddProductBarcodeNo.Text).ProductID;
                        GoProductDetails(lastAddedProductID);
                        // todo: eklenen ürüne ait olan detay sayfasında yonlendirilecek
                        CleanAddAndUpdateProduct();
                    }
                    else
                    {
                        MessageBox.Show("Ürün zaten mevcutta var");
                    }
                }
            }
            else
            {
                if (isUpdatable)
                {
                    if (isUpdateProductFieldValidator())
                    {
                        UpdateProductDTO updateDto = new UpdateProductDTO()
                        {
                            AddedBy = User.UserID,
                            Barcode = txtAddAndUpdateProductUpdateProductBarcodeNo.Text,
                            CategoryID = ((CategoryDTO)cmbBoxAddAndUpdateProductUpdateProductCategory.SelectedItem).CategoryID,
                            ProductName = txtAddAndUpdateProductUpdateProductProductName.Text,
                            SupplierID = ((SupplierDTO)cmbBoxAddAndUpdateProductUpdateProductSupplier.SelectedItem).SupplierID,
                            PictureBackPath = FileDialogUpdateProductBack.FileName,
                            PictureFronthPath = FileDialogUpdateProductFront.FileName,
                            ProductContent = txtAddAndUpdateProductUpdateProductProductContext.Text
                        };
                        bool result = dal.UpdateProduct(updateDto);
                        if (result)
                        {
                            MessageBox.Show("Ürün Güncellendi");
                            // todo: eklenen ürüne ait olan detay sayfasında yonlendirilecek
                            int lastUpdatedProductID = useProductDAL.GetProductDetailWithBarcode(txtAddAndUpdateProductUpdateProductBarcodeNo.Text).ProductID;
                            GoProductDetails(lastUpdatedProductID);
                            CleanAddAndUpdateProduct();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Barkod kullanarak ürünü getirin.");
                }
            }
            btnAddAndUpdateProductSend.Enabled = true;
        }

        private void AddAndUpdateProductBtnGetProductDetail_Click(object sender, EventArgs e)
        {
            txtAddAndUpdateProductUpdateProductBarcodeNo.Enabled = false;
            if (txtAddAndUpdateProductUpdateProductBarcodeNo.Text != "" && txtAddAndUpdateProductUpdateProductBarcodeNo.Text.Length == 7)
            {

                dto = useProductDAL.GetProductDetailWithBarcode(txtAddAndUpdateProductUpdateProductBarcodeNo.Text);
                if (dto != null)
                {
                    if (dto.AddedBy == User.UserID)
                    {
                        txtAddAndUpdateProductUpdateProductBarcodeNo.Text = dto.Barcode;
                        cmbBoxAddAndUpdateProductUpdateProductSupplier.SelectedIndex = cmbBoxAddAndUpdateProductUpdateProductSupplier.FindString(dto.SupplierName);
                        txtAddAndUpdateProductUpdateProductProductName.Text = dto.ProductName;
                        txtAddAndUpdateProductUpdateProductProductContext.Text = dto.ProductContent;
                        cmbBoxAddAndUpdateProductUpdateProductCategory.SelectedIndex = cmbBoxAddAndUpdateProductUpdateProductCategory.FindString(dto.CategoryName);
                        FileDialogUpdateProductFront.FileName = dto.PictureFronthPath;
                        FileDialogUpdateProductBack.FileName = dto.PictureBackPath;
                        var item = dto.PictureFronthPath.Split('\\');
                        btnAddAndUpdateProductUpdateProductFront.Text = item[item.Length - 1];
                        item = dto.PictureBackPath.Split('\\');
                        btnAddAndUpdateProductUpdateProductBack.Text = item[item.Length - 1];
                        isUpdatable = true;
                    }
                    else
                    {
                        MessageBox.Show("Bu Ürün size ait değil.Düzenleme yapılamaz");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen Barkodlu ürün bulunamadı");
                }
            }
            else if (txtAddAndUpdateProductUpdateProductBarcodeNo.Text == "")
            {
                MessageBox.Show("Ürün barkod no giriniz");
            }
            else
            {
                MessageBox.Show("Barkod No hatalı");
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SignInSignUpForm f = new SignInSignUpForm();
            f.Show();
            this.Close();
        }
        private void btnSearchHistoryAndFavoriList_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            dgvSearchHistory.DataSource = useSearchHistoryDAL.GetSearchHistoryListWithUserID(User.UserID).OrderByDescending(x => x.SearchDate).ToList();
            SearchHistory.Visible = true;
        }

        private void ClearHistory(object sender, EventArgs e)
        {
            useSearchHistoryDAL.ClearSearchHistoryWithUserID(User.UserID);
            MessageBox.Show("Arama geçmişi temizlendi!");
            dgvSearchHistory.DataSource = null;
        }

        #region FileDialogs

        private void UpdateProductFrontImageName(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnAddAndUpdateProductUpdateProductFront.Text = FileDialogUpdateProductFront.SafeFileName;
        }
        private void UpdateProductBackImageName(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnAddAndUpdateProductUpdateProductBack.Text = FileDialogUpdateProductBack.SafeFileName;
        }
        private void AddProductFrontImageName(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnAddAndUpdateProductAddProductFront.Text = FileDialogAddProductFront.SafeFileName;
        }
        private void addProductBackImageName(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnAddAndUpdateProductAddProductBack.Text = FileDialogAddProductBack.SafeFileName;
        }

        #endregion

        private void UpdateProductFrontImageDialogShow(object sender, EventArgs e)
        {
            FileDialogUpdateProductFront.ShowDialog();
        }
        private void UpdateProductBackImageDialogShow(object sender, EventArgs e)
        {
            FileDialogUpdateProductBack.ShowDialog();
        }
        private void AddProductFrontImageDialogShow(object sender, EventArgs e)
        {
            FileDialogAddProductFront.ShowDialog();
        }
        private void AddProductBackImageDialogShow(object sender, EventArgs e)
        {
            FileDialogAddProductBack.ShowDialog();
        }

        private bool isAddProductFieldValidator()
        {
            if (string.IsNullOrEmpty(txtAddAndUpdateProductAddProductBarcodeNo.Text))
            {
                MessageBox.Show("Ürün barcode boş olamaz.");
                return false;
            }
            else if (string.IsNullOrEmpty(txtAddAndUpdateProductAddProductProductName.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz");
                return false;
            }
            else if (cmbBoxAddAndUpdateProductAddProductCategory.SelectedItem == null)
            {
                MessageBox.Show("Ürün kategori seçilmedi");
                return false;
            }
            else if (cmbBoxAddAndUpdateProductAddProductSupplier.SelectedItem == null)
            {
                MessageBox.Show("Ürün üretici secilmedi");
                return false;
            }
            else if (string.IsNullOrEmpty(txtAddAndUpdateProductAddProductProductContext.Text))
            {
                MessageBox.Show("Ürün İçeriği boş olamaz");
                return false;
            }
            return true;
        }

        private bool isUpdateProductFieldValidator()
        {
            var frontpicturepath = dto.PictureFronthPath.Split('\\');
            var frontpicture = frontpicturepath[frontpicturepath.Length - 1];

            var backpicturepath = dto.PictureBackPath.Split('\\');
            var backpicture = backpicturepath[backpicturepath.Length - 1];
            if (txtAddAndUpdateProductUpdateProductBarcodeNo.Text == dto.Barcode &&
                txtAddAndUpdateProductUpdateProductProductName.Text == dto.ProductName &&
                txtAddAndUpdateProductUpdateProductProductContext.Text == dto.ProductContent &&
                ((CategoryDTO)cmbBoxAddAndUpdateProductUpdateProductCategory.SelectedItem).CategoryID == dto.CategoryID &&
                ((SupplierDTO)cmbBoxAddAndUpdateProductUpdateProductSupplier.SelectedItem).SupplierID == dto.SupplierID &&
                btnAddAndUpdateProductUpdateProductFront.Text == frontpicture &&
                btnAddAndUpdateProductUpdateProductBack.Text == backpicture)
            {
                MessageBox.Show("Ürünün güncellenen verisi yok.");
                return false;
            }
            return true;
        }

        private void CleanAddAndUpdateProduct()
        {
            txtAddAndUpdateProductUpdateProductBarcodeNo.Text = "";
            txtAddAndUpdateProductUpdateProductProductName.Text = "";
            txtAddAndUpdateProductAddProductBarcodeNo.Text = "";
            txtAddAndUpdateProductAddProductProductName.Text = "";
            txtAddAndUpdateProductUpdateProductProductContext.Text = "";
            txtAddAndUpdateProductAddProductProductContext.Text = "";
            cmbBoxAddAndUpdateProductUpdateProductCategory.SelectedItem = null;
            cmbBoxAddAndUpdateProductUpdateProductSupplier.SelectedItem = null;
            cmbBoxAddAndUpdateProductAddProductCategory.SelectedItem = null;
            cmbBoxAddAndUpdateProductAddProductSupplier.SelectedItem = null;
            txtAddAndUpdateProductUpdateProductBarcodeNo.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            SearchProduct.Visible = true;
        }

        private void btnSearchSearchbar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchProductSearchSearchbar.Text.Trim()))
            {
                string aranacak = txtSearchProductSearchSearchbar.Text;
                List<ListProductDTO> result = useProductDAL.GetProductListForSearchbar(aranacak);
                dgvSearchProductProducts.DataSource = result;
                dgvSearchProductProducts.Columns[0].Visible = false;
                dgvSearchProductProducts.Columns[1].ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Lütfen harf veya kelime giriniz!");
            }
        }

        private void dataGridViewProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int selectedProductID = Convert.ToInt32(dgvSearchProductProducts.Rows[e.RowIndex].Cells[0].Value);

                useSearchHistoryDAL.AddSearchHistory(new AddSearchHistoryDTO
                {
                    UserID = User.UserID,
                    ProductID = selectedProductID,
                });

                GoProductDetails(selectedProductID);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void CreateProductsInLabel(List<ListSupplementDTO> supplements)
        {
            int Y = 0;
            if (pnlProductDetailsShowProducts.Controls.Count != 0)
            {
                Y = 0;
                pnlProductDetailsShowProducts.Controls.Clear();
            }
            int temizNum = 0;
            int azriskNum = 0;
            int ortariskNum = 0;
            int riskNum = 0;

            for (int i = 0; i < supplements.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = supplements[i].SupplementName;
                lbl.Name = i.ToString();
                lbl.Size = new Size(300, 18);

                switch (supplements[i].RiskRatio)
                {
                    case Risk.Temiz:
                        lbl.ForeColor = Color.FromArgb(0, 64, 0);
                        temizNum += 1;
                        break;

                    case Risk.AzRiskli:
                        lbl.ForeColor = Color.FromArgb(241, 196, 15);
                        azriskNum += 1;
                        break;

                    case Risk.OrtaRiskli:
                        lbl.ForeColor = Color.Orange;
                        ortariskNum += 1;
                        break;

                    case Risk.Riskli:
                        lbl.ForeColor = Color.Red;
                        riskNum += 1;
                        break;

                    default:
                        break;
                }

                lbl.BackColor = Color.White;
                lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
                lbl.Location = new Point(15, 30 * (Y + 1));
                Y++;
                pnlProductDetailsShowProducts.Controls.Add(lbl);
            }
            lblProductDetailsCleanCount.Text = temizNum.ToString();
            lblProductDetailsLowerRiskCount.Text = azriskNum.ToString();
            lblProductDetailsMidRiskCount.Text = ortariskNum.ToString();
            lblProductDetailsHighRiskCount.Text = riskNum.ToString();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            if (!isProductSupplementOpen)
            {
                ProductSupplementDetailOpen();
            }
            else
            {
                ProductSupplementDetailClose();
            }
        }
        private void btnClearDGV_Click(object sender, EventArgs e)
        {
            dgvSearchProductProducts.DataSource = null;
            txtSearchProductSearchSearchbar.Text = "";
        }

        private void cbFavLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFavoriListFavProducts.DataSource = null;
            selectedFavList = (FavListDTO)cmbBoxFavoriListFavoriLists.SelectedItem;
            dgvFavoriListFavProducts.DataSource = useProductFavListDAL.GetProductsWithFavListID(selectedFavList.FavorID);
            dgvFavoriListFavProducts.Columns[0].Visible = false;
            dgvFavoriListFavProducts.Columns[1].ReadOnly = true;
            dgvFavoriListFavProducts.Columns[1].HeaderText = "Ürün";
        }

        private void dgvFavProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedProductID = Convert.ToInt32(dgvFavoriListFavProducts.Rows[e.RowIndex].Cells[0].Value);

                GoProductDetails(selectedProductID);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GoFavoriListPage(object sender, EventArgs e)
        {
            CloseAllPages();
            GetFavoriLists();
            Favlists.Visible = true;
        }
        private void GetFavoriLists()
        {
            cmbBoxFavoriListFavoriLists.Items.Clear();
            List<FavListDTO> favLists = useFavListDAL.GetFavListsWithUserID(User.UserID);
            if (favLists.Count != 0)
            {
                foreach (FavListDTO item in favLists)
                {
                    cmbBoxFavoriListFavoriLists.Items.Add(item);
                }
                cmbBoxFavoriListFavoriLists.SelectedIndex = 0;
                selectedFavList = (FavListDTO)cmbBoxFavoriListFavoriLists.SelectedItem;
                dgvFavoriListFavProducts.DataSource = useProductFavListDAL.GetProductsWithFavListID(selectedFavList.FavorID);
                dgvFavoriListFavProducts.Columns[0].Visible = false;
                dgvFavoriListFavProducts.Columns[1].ReadOnly = true;
                dgvFavoriListFavProducts.Columns[1].HeaderText = "Ürün";
            }
            else
            {
                cmbBoxFavoriListFavoriLists.Text = "Favori listesi bulunamadı";
            }
        }
        private void GoBlackListPage(object sender, EventArgs e)
        {
            CloseAllPages();
            GetBlackList();
            BlackList.Visible = true;
        }

        private void GetBlackList()
        {
            int blacklistID = useBlackListDAL.GetBlackListIDWithUserID(User.UserID);
            if (blacklistID != 0)
            {
                dgvBlackListSupplements.DataSource = useSupplementBlackListDAL.GetSupplementsWithBlackListID(blacklistID);
                dgvBlackListSupplements.Columns[0].Visible = false;
                dgvBlackListSupplements.Columns[1].ReadOnly = true;
                dgvBlackListSupplements.Columns[1].HeaderText = "Madde";
            }
            else
            {
                lblBlackListWarning.Text = "Kara Liste bulunamadı";
            }
        }

        bool isBackPicture = false;
        private void ProductDetailsChangeProductImage(object sender, EventArgs e)
        {
            isBackPicture = !isBackPicture;
            if (isBackPicture)
            {
                pictureProductDetailsProductImage.Image = Image.FromFile(selectedProduct.PictureBackPath);
            }
            else
            {
                pictureProductDetailsProductImage.Image = Image.FromFile(selectedProduct.PictureFronthPath);
            }
        }
        private void ProductSupplementDetailOpen()
        {
            isProductSupplementOpen = true;
            this.MaximumSize = new Size(380, 630);
            this.MinimumSize = new Size(380, 630);
            this.Height = 630;
            ProductDetails.Height = 630;
            pnlProductDetailsShowProducts.Height = 550;
            pnlProductDetailsShowProducts.BackColor = Color.Gray;
            pnlProductDetailsShowProducts.Visible = true;
            //btnShowList.BackgroundImage = Image.FromFile(@"C:\Projects\BAYP\YesilEvCodeFirst\YesilEvCodeFirst.UIWinForm\ContextLtst\Image\up.jpg");
        }
        private void ProductSupplementDetailClose()
        {
            isProductSupplementOpen = false;
            this.MaximumSize = new Size(380, 550);
            this.MinimumSize = new Size(380, 550);
            this.Height = 550;
            pnlProductDetailsShowProducts.Height = 35;
            pnlProductDetailsShowProducts.Visible = false;
            //btnShowList.BackgroundImage = Image.FromFile(@"C:\Projects\BAYP\YesilEvCodeFirst\YesilEvCodeFirst.UIWinForm\ContextLtst\Image\drop.jpg");
        }

        private void CloseAllPages()
        {
            Home.Visible = false;
            AddAndUpdateProduct.Visible = false;
            UserDetails.Visible = false;
            SearchHistory.Visible = false;
            Favlists.Visible = false;
            BlackList.Visible = false;
            SearchProduct.Visible = false;
            Home.Visible = false;
            ProductDetails.Visible = false;
            SearchBarcode.Visible = false;
            AddFavoriList.Visible = false;
            ChangeEmail.Visible = false;
            ChangePassword.Visible = false;
            ChangeUserDetails.Visible = false;
            CloseSideBar();
            ProductSupplementDetailClose();
        }
        private void GetAddAndUpdateProductCategoriesAndSuppliers()
        {
            List<SupplierDTO> suppliers = useSupplierDAL.GetSupplierList();
            List<CategoryDTO> categories = useCategoryDAL.GetCategoryList();
            foreach (SupplierDTO item in suppliers)
            {
                cmbBoxAddAndUpdateProductAddProductSupplier.Items.Add(item);
                cmbBoxAddAndUpdateProductUpdateProductSupplier.Items.Add(item);
            }
            foreach (CategoryDTO item in categories)
            {
                cmbBoxAddAndUpdateProductAddProductCategory.Items.Add(item);
                cmbBoxAddAndUpdateProductUpdateProductCategory.Items.Add(item);
            }

        }
        private void btnReadBarcode_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            SearchBarcode.Visible = true;
        }

        private void GoProductDetails(int productID)
        {
            // todo: urun duzenleme yapildigi zaman, bu metot cagirildiginda 612. satirda guncellemeden onceki verileri getiriliyor.
            // hocaya sorulacak

            CloseAllPages();

            ProductDetails.Visible = true;

            selectedProduct = useProductDAL.GetProductDetailWithID(productID);
            UserDetailDTO adder = useUserDAL.GetUserDetailWithID(selectedProduct.AddedBy);

            lblProductDetailsLowerCategory.Text = selectedProduct.CategoryName;
            lblProductDetailsSupplier.Text = selectedProduct.SupplierName;
            lblProductDetailsProductName.Text = selectedProduct.ProductName;
            lblProductDetailsMessage.Text = adder.FirstName + " " + adder.LastName + " tarafından oluşturulmuştur.";
            pictureProductDetailsProductImage.Image = Image.FromFile(selectedProduct.PictureFronthPath);
            pictureProductDetailsProductImage.BackgroundImageLayout = ImageLayout.Tile;
            List<ListSupplementDTO> supplements = useProductSupplementDAL.GetSupplementsWithProductID(productID);
            CreateProductsInLabel(supplements);
        }


        private void btnSearchProductWithBarcodeNo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchBarcodeBarcodeNo.Text.Trim()))
            {
                MessageBox.Show("Barkod No boş olamaz.");
            }
            else if (txtSearchBarcodeBarcodeNo.Text.Length != 7)
            {
                MessageBox.Show("Barkod Hatalı tekrar giriş yapınız.");
            }
            else
            {
                CloseAllPages();
                GetProductDetailDTO result = useProductDAL.GetProductDetailWithBarcode(txtSearchBarcodeBarcodeNo.Text);
                if (result != null)
                {
                    ProductDetails.Visible = true;
                    GoProductDetails(result.ProductID);
                }
                else
                {
                    AddAndUpdateProduct.Visible = true;
                    txtAddAndUpdateProductAddProductBarcodeNo.Text = txtSearchBarcodeBarcodeNo.Text;
                }
            }
        }

        private void dgvProducts_MouseClick(object sender, MouseEventArgs e)
        {
            
            int selectedRow = -1;
            selectedRow = dgvSearchProductProducts.HitTest(e.X, e.Y).RowIndex;

            if (e.Button == MouseButtons.Right)
            {
                if (selectedRow >= 0)
                {
                    GetFavoriListsAddProductAndDeleteProduct(selectedRow, e.X, e.Y);
                }
                else if (selectedRow != dgvSearchProductProducts.RowCount - 1)
                {
                    MessageBox.Show("Yanlış yere tıkladınız.");
                }
            }
        }
        private void GetFavoriListsAddProductAndDeleteProduct(int selectedRow, int Eventx , int Eventy){
            var favLists = useFavListDAL.GetFavListsWithUserID(User.UserID);
            ContextMenu cm = new ContextMenu();
            MenuItem favEkle = new MenuItem();
            MenuItem favSil = new MenuItem();
            favEkle.Text = "Favori Ekle";
            favSil.Text = "Favori'den Kaldır";
            if (favLists.Count > 0)
            {
                addProductFavListDTO = new AddProductFavListDTO();
                addProductFavListDTO.ProductID = Convert.ToInt32(dgvSearchProductProducts.Rows[selectedRow].Cells[0].Value);
                addProductFavListDTO.UserID = User.UserID;
                favLists.ForEach(x => {
                    if (!useProductFavListDAL.IsFavoriListHaveTheProduct(x.FavorID, addProductFavListDTO.ProductID))
                    {
                        favEkle.MenuItems.Add(new MenuItem(x.FavoriListName, new EventHandler(AddFav)));
                    }
                    else
                    {
                        favSil.MenuItems.Add(new MenuItem(x.FavoriListName, new EventHandler(DeleteFav)));
                    }
                });
                if (favEkle.MenuItems.Count > 0)
                {
                    cm.MenuItems.Add(favEkle);
                }
                if (favSil.MenuItems.Count > 0)
                {
                    cm.MenuItems.Add(favSil);
                }
            }
            else
            {
                favEkle.MenuItems.Add(new MenuItem("Yeni Liste Ekle", new EventHandler(AddFavoriListPage)));
                cm.MenuItems.Add(favEkle);
            }
            cm.Show(dgvSearchProductProducts, new Point(Eventx, Eventy));
        }
        private void AddFav(object sender, EventArgs e)
        {
            var clikMenuItem = sender as MenuItem;
            var MenuText = clikMenuItem.Text;
            addProductFavListDTO.FavorID = useFavListDAL.GetFavListIDWithFavListNameAndUserID(User.UserID, MenuText);
            bool result = useProductFavListDAL.AddProductToFavList(addProductFavListDTO);
            if (result)
            {
                MessageBox.Show("Ürün Favori'ye Eklendi.");
            }
            else
            {
                MessageBox.Show("Ürün Favoriye Eklenirken Hata Oluştu.");
            }
            addProductFavListDTO = null;
        }
        private void DeleteFav(object sender, EventArgs e)
        {
            var clickMenuItem = sender as MenuItem;
            var MenuText = clickMenuItem.Text;
            addProductFavListDTO.FavorID = useFavListDAL.GetFavListIDWithFavListNameAndUserID(User.UserID, MenuText);
            bool result = useProductFavListDAL.DeleteProductFavList(addProductFavListDTO);
            if (result)
            {
                MessageBox.Show("Ürün Favori'den Silindi.");
            }
            else
            {
                MessageBox.Show("Ürün Favori'den Silinirken Hata Oluştu.");
            }
            addProductFavListDTO = null;
        }
        private void AddFavoriListPage(object sender , EventArgs e)
        {
            CloseAllPages();
            AddFavoriList.Visible = true;
        }

        private void btnAddFavoriList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddFavoriFavoriName.Text.Trim()))
            {
                MessageBox.Show("Favori ismi alanı boş olamaz.");
            }
            else
            {
                //to do messagebox favori isminden emin misiniz okay derse işlem yapılacak

                AddFavListDTO addFavList = new AddFavListDTO()
                {
                    FavoriListName = txtAddFavoriFavoriName.Text,
                    UserID = User.UserID,
                };
                bool result = useFavListDAL.AddFavList(addFavList);
                if (result)
                {
                    MessageBox.Show("Liste Eklendi , Favori listelerine Gidiliyor.");
                    txtAddFavoriFavoriName.Text = "";
                    CloseAllPages();
                    GetFavoriLists();
                    Favlists.Visible = true;
                }
            }
        }

        private void btnUserDetailsMergeSocialMedia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapım Aşamasında ...");
        }

        private void btnUserDetailsPremium_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapım Aşamasında ...");
        }

        private void btnUserDetailsChangeEmail_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            txtChangeEmailUserEmail.Text = User.Email;
            ChangeEmail.Visible = true;
        }

        private void btnUserDetailsChangePassword_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            ChangePassword.Visible = true;
        }

        private void btnUserDetailsUpdateUserDetails_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            ChangeUserDetails.Visible = true;
            txtChangeUserDetailsFirstName.Text = User.FirstName;
            txtChangeUserDetailsFirstName.Tag = "0";
            txtChangeUserDetailsLastName.Text = User.LastName;
            txtChangeUserDetailsLastName.Tag = "0";
            txtChangeUserDetailsPhone.Text = User.Phone;
            txtChangeUserDetailsPhone.Tag = "0";
        }

        private void btnChangeUserDetailsSend_Click(object sender, EventArgs e)
        {
            UpdateUserDetailsDTO userDetails = new UpdateUserDetailsDTO()
            {
                UserID = User.UserID,
                FirstName = txtChangeUserDetailsFirstName.Text,
                LastName = txtChangeUserDetailsLastName.Text,
                Phone = txtChangeUserDetailsPhone.Text
            };
            bool result = useUserDAL.UpdateUserDetails(userDetails);
            if (result)
            {
                MessageBox.Show("Kullanıcı Bilgileri Güncellendi.");
                User.FirstName = txtChangeUserDetailsFirstName.Text;
                User.LastName = txtChangeUserDetailsLastName.Text;
                User.Phone = txtChangeUserDetailsPhone.Text;
            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgileri Güncellenirken Hata Oluştu.Sonra tekrar deneyiniz.");
            }
        }

        private void txtFirstClickClear(object sender, EventArgs e)
        {
            TextBox clicked = sender as TextBox;
            if (clicked.Tag == (object)"0")
            {
                clicked.Text = "";
                clicked.Tag = null;
            }
        }

        private void btnChangeEmailSend_Click(object sender, EventArgs e)
        {
            if(txtChangeEmailUserEmail.Text == User.Email)
            {
                if(txtChangeEmailNewEmail.Text == txtChangeEmaiReNewEmail.Text)
                {
                    UpdateUserEmailDTO userDetails = new UpdateUserEmailDTO()
                    {
                        UserID = User.UserID,
                        NewEmail = txtChangeEmailNewEmail.Text,
                    };
                    bool result = useUserDAL.UpdateUserEmail(userDetails);
                    if (result)
                    {
                        MessageBox.Show("Email Bilgisi Güncellendi.");
                        User.Email = txtChangeEmailNewEmail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Bilgileri Güncellenirken Hata Oluştu.Sonra tekrar deneyiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Yeni Email ve Yeni Email Tekrar Alanları aynı değil.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Email doğru değil.");
            }
        }

        private void btnChangePasswordSend_Click(object sender, EventArgs e)
        {
            if (txtChangePasswordPassword.Text == User.Password)
            {
                if (txtChangePasswordNewPassword == txtChangePasswordReNewPassword)
                {
                    UpdateUserPasswordDTO userDetails = new UpdateUserPasswordDTO()
                    {
                        UserID = User.UserID,
                        NewPassword = txtChangePasswordNewPassword.Text,
                    };
                    bool result = useUserDAL.UpdateUserPassword(userDetails);
                    if (result)
                    {
                        MessageBox.Show("Şifre Bilgisi Güncellendi.");
                        User.Password = txtChangePasswordNewPassword.Text;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Bilgileri Güncellenirken Hata Oluştu.Sonra tekrar deneyiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Yeni Şifre ve Yeni Şifre Tekrar Alanları aynı değil.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Şifresi doğru değil.");
            }
        }
    }
}
