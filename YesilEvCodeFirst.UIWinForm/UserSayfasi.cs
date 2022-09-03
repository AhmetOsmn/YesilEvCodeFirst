using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.DTOs.Product;
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

        public UserDetailDTO Kullanici;
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
            Anasayfa.Visible = true;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBarKapa();
            }
            else
            {
                sideBarAc();
            }
        }
        private void sideBarAc()
        {
            foreach (Panel item in SideBar.Controls)
            {
                if (item.Name == "pnlHome" || item.Name == "pnlMenu")
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
        private void sideBarKapa()
        {
            foreach (Panel item in SideBar.Controls)
            {

                if (item.Name == "pnlHome" || item.Name == "pnlMenu")
                {
                    pnlYesilEv.Width = 10;
                    pnlUygulamaPuanVer.Width = 10;
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
            Anasayfa.Visible = true;
        }

        private void UrunDuzenle_Click(object sender, EventArgs e)
        {
            UrunEkle.Visible = false;
            isAddProduct = false;
            btnUrunDuzenle.BackColor = Color.DarkGreen;
            UrunDuzenle.Visible = true;
            btnUrunEkle.BackColor = Color.Green;
            Clean();
        }

        private void UrunEkle_Click(object sender, EventArgs e)
        {
            UrunDuzenle.Visible = false;
            isAddProduct = true;
            isUpdatable = false;
            btnUrunEkle.BackColor = Color.DarkGreen;
            UrunEkle.Visible = true;
            btnUrunDuzenle.BackColor = Color.Green;
            Clean();
        }

        private void UrunEkleDuzenle_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            List<SupplierDTO> suppliers = useSupplierDAL.GetSupplierList();
            List<CategoryDTO> categories = useCategoryDAL.GetCategoryList();
            foreach (SupplierDTO item in suppliers)
            {
                cmbBoxUrunEkleUretici.Items.Add(item);
                cmbBoxUretici.Items.Add(item);
            }
            foreach (CategoryDTO item in categories)
            {
                cmbBoxUrunEkleKategori.Items.Add(item);
                cmbBoxKategori.Items.Add(item);
            }
            UrunEkleDuzenle.Visible = true;
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            UserBilgileri.Visible = true;
            lblUyelikTarihiValue.Text = Kullanici.CreatedDate.ToString();
            lblUserName.Text = Kullanici.FirstName + " " + Kullanici.LastName;
            labelUrunSayisi.Text = useProductDAL.GetProductListWithUserID(Kullanici.UserID).Count.ToString();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            btnGonder.Enabled = false;
            UseProductDAL dal = new UseProductDAL();
            if (isAddProduct)
            {
                if (isAddProductFieldValidator())
                {
                    bool result = dal.AddProduct(new AddProductDTO
                    {
                        AddedBy = Kullanici.UserID,
                        Barcode = txtUrunEkleBarkod.Text,
                        SupplierID = ((SupplierDTO)cmbBoxUrunEkleUretici.SelectedItem).SupplierID,
                        ProductName = txtUrunEkleUrunAdi.Text,
                        CategoryID = ((CategoryDTO)cmbBoxUrunEkleKategori.SelectedItem).CategoryID,
                        ProductContent = txtUrunEkleUrunIcerik.Text,
                        //to do file dialog get path
                        PictureFronthPath = FileDialogUrunEkleOnYuz.FileName,
                        PictureBackPath = FileDialogUrunEkleArkaYuz.FileName,
                    });
                    if (result)
                    {
                        MessageBox.Show("Ürün Eklendi");
                        CloseAllPages();
                        int lastAddedProductID = useProductDAL.GetProductDetailWithBarcode(txtUrunEkleBarkod.Text).ProductID;
                        GoProductDetails(lastAddedProductID);
                        // todo: eklenen ürüne ait olan detay sayfasında yonlendirilecek
                        Clean();
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
                            AddedBy = Kullanici.UserID,
                            Barcode = txtBarkodNo.Text,
                            CategoryID = ((CategoryDTO)cmbBoxKategori.SelectedItem).CategoryID,
                            ProductName = txtUrunAdi.Text,
                            SupplierID = ((SupplierDTO)cmbBoxUretici.SelectedItem).SupplierID,
                            PictureBackPath = FileDialogArkaYuz.FileName,
                            PictureFronthPath = FileDialogOnYuz.FileName,
                            ProductContent = txtUrunIcerik.Text
                        };
                        bool result = dal.UpdateProduct(updateDto);
                        if (result)
                        {
                            MessageBox.Show("Ürün Güncellendi");
                            // todo: eklenen ürüne ait olan detay sayfasında yonlendirilecek
                            int lastUpdatedProductID = useProductDAL.GetProductDetailWithBarcode(txtBarkodNo.Text).ProductID;
                            GoProductDetails(lastUpdatedProductID);
                            Clean();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Barkod kullanarak ürünü getirin.");
                }
            }
            btnGonder.Enabled = true;
        }

        private void btnUrunGetir_Click(object sender, EventArgs e)
        {
            txtBarkodNo.Enabled = false;
            if (txtBarkodNo.Text != "" && txtBarkodNo.Text.Length == 7)
            {

                dto = useProductDAL.GetProductDetailWithBarcode(txtBarkodNo.Text);
                if (dto != null)
                {
                    if (dto.AddedBy == Kullanici.UserID)
                    {
                        txtBarkodNo.Text = dto.Barcode;
                        cmbBoxUretici.SelectedIndex = cmbBoxUretici.FindString(dto.SupplierName);
                        txtUrunAdi.Text = dto.ProductName;
                        txtUrunIcerik.Text = dto.ProductContent;
                        cmbBoxKategori.SelectedIndex = cmbBoxKategori.FindString(dto.CategoryName);
                        FileDialogOnYuz.FileName = dto.PictureFronthPath;
                        FileDialogArkaYuz.FileName = dto.PictureBackPath;
                        var item = dto.PictureFronthPath.Split('\\');
                        btnOnYuz.Text = item[item.Length - 1];
                        item = dto.PictureBackPath.Split('\\');
                        btnArkaYuz.Text = item[item.Length - 1];
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
            else if (txtBarkodNo.Text == "")
            {
                MessageBox.Show("Ürün barkod no giriniz");
            }
            else
            {
                MessageBox.Show("Barkod No hatalı");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            GirisKayitForm f = new GirisKayitForm();
            f.Show();
            this.Close();

        }
        private void btnAramaGecmisiFavori_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            dgvAramaGecmisi.DataSource = useSearchHistoryDAL.GetSearchHistoryListWithUserID(Kullanici.UserID).OrderByDescending(x => x.SearchDate).ToList();
            AramaGecmisi.Visible = true;
        }

        private void GecmisiTemizle(object sender, EventArgs e)
        {
            useSearchHistoryDAL.ClearSearchHistoryWithUserID(Kullanici.UserID);
            MessageBox.Show("Arama geçmişi temizlendi!");
            dgvAramaGecmisi.DataSource = null;
        }

        #region FileDialogs

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnOnYuz.Text = FileDialogOnYuz.SafeFileName;
        }
        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnArkaYuz.Text = FileDialogArkaYuz.SafeFileName;
        }
        private void openFileDialog3_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnUrunEkleOnYuz.Text = FileDialogUrunEkleOnYuz.SafeFileName;
        }
        private void openFileDialog4_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnUrunEkleArkaYuz.Text = FileDialogUrunEkleArkaYuz.SafeFileName;
        }

        #endregion

        private void btnOnYuz_Click(object sender, EventArgs e)
        {
            FileDialogOnYuz.ShowDialog();
        }
        private void btnArkaYuz_Click(object sender, EventArgs e)
        {
            FileDialogArkaYuz.ShowDialog();
        }
        private void btnUrunEkleOnYuz_Click(object sender, EventArgs e)
        {
            FileDialogUrunEkleOnYuz.ShowDialog();
        }
        private void btnUrunEkleArkaYuz_Click(object sender, EventArgs e)
        {
            FileDialogUrunEkleArkaYuz.ShowDialog();
        }

        private bool isAddProductFieldValidator()
        {
            if (string.IsNullOrEmpty(txtUrunEkleBarkod.Text))
            {
                MessageBox.Show("Ürün barcode boş olamaz.");
                return false;
            }
            else if (string.IsNullOrEmpty(txtUrunEkleUrunAdi.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz");
                return false;
            }
            else if (cmbBoxUrunEkleKategori.SelectedItem == null)
            {
                MessageBox.Show("Ürün kategori seçilmedi");
                return false;
            }
            else if (cmbBoxUrunEkleUretici.SelectedItem == null)
            {
                MessageBox.Show("Ürün üretici secilmedi");
                return false;
            }
            else if (string.IsNullOrEmpty(txtUrunEkleUrunIcerik.Text))
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
            if (txtBarkodNo.Text == dto.Barcode &&
                txtUrunAdi.Text == dto.ProductName &&
                txtUrunIcerik.Text == dto.ProductContent &&
                ((CategoryDTO)cmbBoxKategori.SelectedItem).CategoryID == dto.CategoryID &&
                ((SupplierDTO)cmbBoxUretici.SelectedItem).SupplierID == dto.SupplierID &&
                btnOnYuz.Text == frontpicture &&
                btnArkaYuz.Text == backpicture)
            {
                MessageBox.Show("Ürünün güncellenen verisi yok.");
                return false;
            }
            return true;
        }

        private void Clean()
        {
            txtBarkodNo.Text = "";
            txtUrunAdi.Text = "";
            txtUrunEkleBarkod.Text = "";
            txtUrunEkleUrunAdi.Text = "";
            txtUrunIcerik.Text = "";
            txtUrunEkleUrunIcerik.Text = "";
            cmbBoxKategori.SelectedItem = null;
            cmbBoxUretici.SelectedItem = null;
            cmbBoxUrunEkleKategori.SelectedItem = null;
            cmbBoxUrunEkleUretici.SelectedItem = null;
            txtBarkodNo.Enabled = true;
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            UrunArama.Visible = true;
        }

        private void btnSearchbarAra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAramaSearchbar.Text.Trim()))
            {
                string aranacak = txtAramaSearchbar.Text;
                List<ListProductDTO> result = useProductDAL.GetProductListForSearchbar(aranacak);
                dataGridViewProducts.DataSource = result;
                dataGridViewProducts.Columns[0].Visible = false;
                dataGridViewProducts.Columns[1].ReadOnly = true;
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
                int selectedProductID = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value);

                useSearchHistoryDAL.AddSearchHistory(new AddSearchHistoryDTO
                {
                    UserID = Kullanici.UserID,
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
            if (pnlShowProducts.Controls.Count != 0)
            {
                Y = 0;
                pnlShowProducts.Controls.Clear();
            }
            for (int i = 0; i < supplements.Count; i++)
            {
                Label lbl = new Label();
                lbl.Text = supplements[i].SupplementName;
                lbl.Name = i.ToString();
                lbl.Size = new Size(300, 18);
                lbl.BackColor = Color.White;
                lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
                lbl.ForeColor = Color.Black;
                lbl.Location = new Point(15, 20 * (Y + 1));
                Y++;
                pnlShowProducts.Controls.Add(lbl);
            }
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
        private void btnDGVTemizle_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = null;
            txtAramaSearchbar.Text = "";
        }

        private void cbFavLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFavProducts.DataSource = null;
            selectedFavList = (FavListDTO)cbFavLists.SelectedItem;
            dgvFavProducts.DataSource = useProductFavListDAL.GetProductsWithFavListID(selectedFavList.FavorID);
            dgvFavProducts.Columns[0].Visible = false;
            dgvFavProducts.Columns[1].ReadOnly = true;
            dgvFavProducts.Columns[1].HeaderText = "Ürün";
        }

        private void dgvFavProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedProductID = Convert.ToInt32(dgvFavProducts.Rows[e.RowIndex].Cells[0].Value);

                GoProductDetails(selectedProductID);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FavoriListeleriniHazirla(object sender, EventArgs e)
        {
            CloseAllPages();
            cbFavLists.Items.Clear();
            List<FavListDTO> favLists = useFavListDAL.GetFavListsWithUserID(Kullanici.UserID);
            if (favLists.Count != 0)
            {
                foreach (FavListDTO item in favLists)
                {
                    cbFavLists.Items.Add(item);
                }
                cbFavLists.SelectedIndex = 0;
                selectedFavList = (FavListDTO)cbFavLists.SelectedItem;
                dgvFavProducts.DataSource = useProductFavListDAL.GetProductsWithFavListID(selectedFavList.FavorID);
                dgvFavProducts.Columns[0].Visible = false;
                dgvFavProducts.Columns[1].ReadOnly = true;
                dgvFavProducts.Columns[1].HeaderText = "Ürün";
            }
            else
            {
                cbFavLists.Text = "Favori listesi bulunamadı";
            }
            pnlFavLists.Visible = true;
        }

        private void KaraListeyiHazirla(object sender, EventArgs e)
        {
            CloseAllPages();
            int blacklistID = useBlackListDAL.GetBlackListIDWithUserID(Kullanici.UserID);
            if (blacklistID != 0)
            {
                dgvBlackListSupplements.DataSource = useSupplementBlackListDAL.GetSupplementsWithBlackListID(blacklistID);
                dgvBlackListSupplements.Columns[0].Visible = false;
                dgvBlackListSupplements.Columns[1].ReadOnly = true;
                dgvBlackListSupplements.Columns[1].HeaderText = "Madde";
            }
            else
            {
                lblKaraListeUyari.Text = "Kara Liste bulunamadı";
            }
            pnlKaraListe.Visible = true;
        }
        bool isBackPicture = false;
        private void UrunDetayResimDegistir_Click(object sender, EventArgs e)
        {
            isBackPicture = !isBackPicture;
            if (isBackPicture)
            {
                pcbUrun.Image = Image.FromFile(selectedProduct.PictureBackPath);
            }
            else
            {
                pcbUrun.Image = Image.FromFile(selectedProduct.PictureFronthPath);
            }
        }
        private void ProductSupplementDetailOpen()
        {
            isProductSupplementOpen = true;
            this.MaximumSize = new Size(380, 630);
            this.MinimumSize = new Size(380, 630);
            this.Height = 630;
            UrunDetay.Height = 630;
            pnlShowProducts.Height = 400;
            pnlShowProducts.BackColor = Color.Red;
            pnlShowProducts.Visible = true;
            //btnShowList.BackgroundImage = Image.FromFile(@"C:\Projects\BAYP\YesilEvCodeFirst\YesilEvCodeFirst.UIWinForm\ContextLtst\Image\up.jpg");
        }
        private void ProductSupplementDetailClose()
        {
            isProductSupplementOpen=false;
            this.MaximumSize = new Size(380, 550);
            this.MinimumSize = new Size(380, 550);
            this.Height = 550;
            pnlShowProducts.Height = 35;
            pnlShowProducts.Visible = false;
            //btnShowList.BackgroundImage = Image.FromFile(@"C:\Projects\BAYP\YesilEvCodeFirst\YesilEvCodeFirst.UIWinForm\ContextLtst\Image\drop.jpg");
        }

        private void CloseAllPages()
        {
            Anasayfa.Visible = false;
            UrunEkleDuzenle.Visible = false;
            UserBilgileri.Visible = false;
            AramaGecmisi.Visible = false;
            pnlFavLists.Visible = false;
            pnlKaraListe.Visible = false;
            UrunArama.Visible = false;
            Anasayfa.Visible = false;
            UrunDetay.Visible = false;
            sideBarKapa();
            ProductSupplementDetailClose();
        }

        private void btnBarkodOku_Click(object sender, EventArgs e)
        {
            //to do barkod okuma sayfası eklenecek
        }
    
        private void GoProductDetails(int productID)
        {
            // todo: urun duzenleme yapildigi zaman, bu metot cagirildiginda 612. satirda guncellemeden onceki verileri getiriliyor.
            // hocaya sorulacak

            CloseAllPages();

            UrunDetay.Visible = true;

            selectedProduct = useProductDAL.GetProductDetailWithID(productID);
            UserDetailDTO adder = useUserDAL.GetUserDetailWithID(selectedProduct.AddedBy);

            lblAltKategori.Text = selectedProduct.CategoryName;
            lblMarka.Text = selectedProduct.SupplierName;
            lblUrunAd.Text = selectedProduct.ProductName;
            lblMessage.Text = adder.FirstName + " " + adder.LastName + " tarafından oluşturulmuştur.";
            pcbUrun.Image = Image.FromFile(selectedProduct.PictureFronthPath);
            pcbUrun.BackgroundImageLayout = ImageLayout.Tile;
            List<ListSupplementDTO> supplements = useProductSupplementDAL.GetSupplementsWithProductID(productID);

            CreateProductsInLabel(supplements);
        }
    
    }
}
