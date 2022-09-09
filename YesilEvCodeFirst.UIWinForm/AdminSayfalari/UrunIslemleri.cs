using NLog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.Supplier;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    public partial class UrunIslemleri : Form
    {
        readonly UseProductDAL useProductDAL = new UseProductDAL();
        readonly UseSupplierDAL useSupplierDAL = new UseSupplierDAL();
        readonly UseCategoryDAL useCategoryDAL = new UseCategoryDAL();
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        UserDetailDTO currentUser = null;
        GetProductDetailDTO currentProductDTO = null;

        public UrunIslemleri(UserDetailDTO dto)
        {
            InitializeComponent();
            CloseAllPanels();
            pnlListele.Visible = true;
            currentUser = dto;
        }

        #region Group Box 

        private void btnListele_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlListele.Visible = true;
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = useProductDAL.GetProductsForAdmin();
            ChangeDatagridViewsColumnNames(dgvProducts);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlAra.Visible = true;
        }

        List<ProductListForAdminDTO> onaylanmamisUrunler = null; 

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            CloseAllPanels();

            pnlApprove.Visible = true;
            dgvApprove.DataSource = null;
            onaylanmamisUrunler = useProductDAL.GetProductsForAdminApprove();
            dgvApprove.DataSource = onaylanmamisUrunler;
            ChangeDatagridViewsColumnNames(dgvApprove);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlUrunEkle.Visible = true;
            List<SupplierDTO> suppliers = useSupplierDAL.GetSupplierList();
            List<CategoryDTO> categories = useCategoryDAL.GetCategoryList();
            foreach (SupplierDTO item in suppliers)
            {
                cbxSuppliers.Items.Add(item);
            }
            foreach (CategoryDTO item in categories)
            {
                cbxCategories.Items.Add(item);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlUrunGuncelle.Visible = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlDeleteProduct.Visible = true;
        }

        #endregion

        #region Search

        private void btnUrunuAra_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            dgvSearchProduct.DataSource = useProductDAL.GetProductListWithSearchbarForAdmin(tbUrunAra.Text);
            //ChangeDatagridViewsColumnNames(dgvSearchProduct);
        }

        #endregion

        #region Approve

        private void btnApproveOnayla_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApprove.Rows)
            {
                bool isApproved = Convert.ToBoolean(row.Cells["IsApproved"].Value);
                if (isApproved)
                {
                    useProductDAL.UpdateIsApprovedForAdmin(Convert.ToInt32(row.Cells["ProductID"].Value), currentUser.UserID);
                }

            }
            dgvApprove.DataSource = useProductDAL.GetProductsForAdminApprove();
        }

        #endregion

        #region Add

        private void btnAddProductContenPic_Click(object sender, EventArgs e)
        {
            FileDialogAddProductContent.ShowDialog();
            var path = FileDialogAddProductContent.FileName.Split('\\');
            btnAddProductContenPic.Text = path[path.Length - 1];
        }

        private void btnFrontPic_Click(object sender, EventArgs e)
        {
            FileDialogAddProductFront.ShowDialog();
            var path = FileDialogAddProductFront.FileName.Split('\\');
            btnFrontPic.Text = path[path.Length - 1];
        }

        private void btnBackPic_Click(object sender, EventArgs e)
        {
            FileDialogAddProductBack.ShowDialog();
            var path = FileDialogAddProductBack.FileName.Split('\\');
            btnBackPic.Text = path[path.Length - 1];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                AddProductDTO addDTO = new AddProductDTO()
                {
                    AddedBy = currentUser.UserID,
                    Barcode = tbBarcode.Text,
                    CategoryID = cbxCategories.SelectedItem == null ? 0 : ((CategoryDTO)cbxCategories.SelectedItem).CategoryID,
                    ProductName = tbProductName.Text,
                    SupplierID = cbxSuppliers.SelectedItem == null ? 0 : ((SupplierDTO)cbxSuppliers.SelectedItem).SupplierID,
                    PictureBackPath = FileDialogAddProductBack.FileName,
                    PictureFronthPath = FileDialogAddProductFront.FileName,
                    PictureContentPath = FileDialogAddProductContent.FileName,
                    ProductContent = tbProductContent.Text
                };
                bool result = useProductDAL.AddProduct(addDTO);
                if (result)
                {
                    MessageBox.Show("Ürün Eklendi");
                    ClearAddProductPanel();
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Update

        private void btnUpdateBarcodeSearch_Click(object sender, EventArgs e)
        {
            List<SupplierDTO> suppliers = useSupplierDAL.GetSupplierList();
            List<CategoryDTO> categories = useCategoryDAL.GetCategoryList();
            foreach (SupplierDTO item in suppliers)
            {
                cbxUpdateSuppliers.Items.Add(item);
            }
            foreach (CategoryDTO item in categories)
            {
                cbxUpdateCategories.Items.Add(item);
            }

            try
            {
                BarcodeDTO barcodeDTO = new BarcodeDTO { Barcode = tbUpdateBarcode.Text };
                currentProductDTO = useProductDAL.GetProductDetailWithBarcode(barcodeDTO);
                if (currentProductDTO != null)
                {
                    EnableUpdateElements();
                    tbUpdateProductName.Text = currentProductDTO.ProductName;
                    cbxUpdateCategories.SelectedIndex = cbxUpdateCategories.FindString(currentProductDTO.CategoryName);
                    cbxUpdateSuppliers.SelectedIndex = cbxUpdateSuppliers.FindString(currentProductDTO.SupplierName);
                    tbUpdateProductContent.Text = currentProductDTO.ProductContent;
                    FileDialogUpdateProductFront.FileName = currentProductDTO.PictureFronthPath;
                    FileDialogUpdateProductBack.FileName = currentProductDTO.PictureBackPath;
                    FileDialogUpdateProductContent.FileName = currentProductDTO.PictureContentPath;
                    var item = currentProductDTO.PictureFronthPath.Split('\\');
                    btnUpdateFrontPic.Text = item[item.Length - 1];
                    item = currentProductDTO.PictureBackPath.Split('\\');
                    btnUpdateBackPic.Text = item[item.Length - 1];
                    item = currentProductDTO.PictureContentPath.Split('\\');
                    btnUpdateProductContentPic.Text = item[item.Length - 1];
                }
                EnableUpdateElements();
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateProductContentPic_Click(object sender, EventArgs e)
        {
            FileDialogUpdateProductContent.ShowDialog();
            var path = FileDialogUpdateProductContent.FileName.Split('\\');
            btnUpdateProductContentPic.Text = path[path.Length - 1];
        }

        private void btnUpdateBackPic_Click(object sender, EventArgs e)
        {
            FileDialogUpdateProductBack.ShowDialog();
            var path = FileDialogUpdateProductBack.FileName.Split('\\');
            btnUpdateBackPic.Text = path[path.Length - 1];
        }

        private void btnUpdateFrontPic_Click(object sender, EventArgs e)
        {
            FileDialogUpdateProductFront.ShowDialog();
            var path = FileDialogUpdateProductFront.FileName.Split('\\');
            btnUpdateFrontPic.Text = path[path.Length - 1];
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            if (isUpdateProductFieldValidator())
            {
                try
                {
                    UpdateProductDTO updateDto = new UpdateProductDTO()
                    {
                        AddedBy = currentUser.UserID,
                        Barcode = tbUpdateBarcode.Text,
                        CategoryID = cbxUpdateCategories.SelectedItem == null ? 0 : ((CategoryDTO)cbxUpdateCategories.SelectedItem).CategoryID,
                        ProductName = tbUpdateProductName.Text,
                        SupplierID = cbxUpdateSuppliers.SelectedItem == null ? 0 : ((SupplierDTO)cbxUpdateSuppliers.SelectedItem).SupplierID,
                        PictureBackPath = FileDialogUpdateProductBack.FileName,
                        PictureFronthPath = FileDialogUpdateProductFront.FileName,
                        PictureContentPath = FileDialogUpdateProductContent.FileName,
                        ProductContent = tbUpdateProductContent.Text
                    };
                    bool result = useProductDAL.UpdateProduct(updateDto);
                    if (result)
                    {
                        MessageBox.Show("Ürün Güncellendi");
                        ClearUpdateProductPanel();
                    }
                }
                catch (FormatException fex)
                {
                    MessageBox.Show(fex.Message);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        #region Delete

        private void btnDeleteDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Emin misiniz?", "Ürün Sil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    BarcodeDTO barcodeDTO = new BarcodeDTO { Barcode = tbDeleteBarcode.Text };
                    useProductDAL.DeleteProduct(barcodeDTO);
                    MessageBox.Show("Ürün silindi!");
                    ClearDeleteProductPanel();
                }
                catch (FormatException fex)
                {
                    nLogger.Error("System - {}", fex.Message);
                    MessageBox.Show(fex.Message);
                }
                catch (Exception ex)
                {
                    nLogger.Error("System - {}", ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteSearch_Click(object sender, EventArgs e)
        {
            try
            {
                BarcodeDTO barcodeDTO = new BarcodeDTO { Barcode = tbDeleteBarcode.Text };
                currentProductDTO = useProductDAL.GetProductDetailWithBarcode(barcodeDTO);
                if (currentProductDTO != null)
                {
                    tbDeleteProductName.Text = currentProductDTO.ProductName;
                    tbDeleteProductContent.Text = currentProductDTO.ProductContent;
                    tbDeleteSupplement.Text = currentProductDTO.SupplierName;
                    tbDeleteCategory.Text = currentProductDTO.CategoryName;
                    //todo: ekleyenin id'si yerine ismi getirilecek
                    tbDeleteAdder.Text = currentProductDTO.AddedBy.ToString();
                }
                btnDeleteDelete.Enabled = true;
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Ozel Metotlar

        private void EnableUpdateElements()
        {
            tbUpdateProductName.Enabled = true;
            cbxUpdateCategories.Enabled = true;
            cbxUpdateSuppliers.Enabled = true;
            tbUpdateProductContent.Enabled = true;
            btnUpdateBackPic.Enabled = true;
            btnUpdateFrontPic.Enabled = true;
            btnUpdateProductContentPic.Enabled = true;
            btnUpdateSave.Enabled = true;
        }

        private void CloseAllPanels()
        {
            pnlListele.Visible = false;
            pnlAra.Visible = false;
            pnlApprove.Visible = false;
            pnlUrunEkle.Visible = false;
            pnlUrunGuncelle.Visible = false;
            pnlDeleteProduct.Visible = false;
        }

        private bool isUpdateProductFieldValidator()
        {
            var frontpicturepath = currentProductDTO.PictureFronthPath.Split('\\');
            var frontpicture = frontpicturepath[frontpicturepath.Length - 1];

            var backpicturepath = currentProductDTO.PictureBackPath.Split('\\');
            var backpicture = backpicturepath[backpicturepath.Length - 1];

            var contenticturepath = currentProductDTO.PictureBackPath.Split('\\');
            var contentpicture = contenticturepath[contenticturepath.Length - 1];

            if (tbUpdateBarcode.Text == currentProductDTO.Barcode &&
                tbUpdateProductName.Text == currentProductDTO.ProductName &&
                tbUpdateProductContent.Text == currentProductDTO.ProductContent &&
                ((CategoryDTO)cbxUpdateCategories.SelectedItem).CategoryID == currentProductDTO.CategoryID &&
                ((SupplierDTO)cbxUpdateSuppliers.SelectedItem).SupplierID == currentProductDTO.SupplierID &&
                btnUpdateFrontPic.Text == frontpicture &&
                btnUpdateBackPic.Text == backpicture &&
                btnUpdateProductContentPic.Text == contentpicture)
            {
                MessageBox.Show("Ürünün güncellenen verisi yok.");
                return false;
            }
            else if (string.IsNullOrEmpty(cbxUpdateCategories.Text) || string.IsNullOrEmpty(cbxUpdateSuppliers.Text))
            {

            }
            return true;
        }

        private void ClearDeleteProductPanel()
        {
            cbxSuppliers.Items.Clear();
            cbxCategories.Items.Clear();
            tbDeleteProductName.Text = "";
            tbDeleteProductContent.Text = "";
            tbDeleteSupplement.Text = "";
            tbDeleteCategory.Text = "";
            tbDeleteBarcode.Text = "";
            tbDeleteAdder.Text = "";
        }

        private void ClearUpdateProductPanel()
        {
            cbxUpdateCategories.Items.Clear();
            cbxUpdateCategories.Text = "";
            cbxUpdateSuppliers.Items.Clear();
            cbxUpdateSuppliers.Text = "";
            tbUpdateBarcode.Text = "";
            tbUpdateProductName.Text = "";
            tbUpdateProductContent.Text = "";
            btnUpdateFrontPic.Text = "Ön Fotoğraf";
            btnUpdateBackPic.Text = "Arka Fotoğraf";
            btnUpdateProductContentPic.Text = "İçerik Fotoğraf";
        }
        
        private void ClearAddProductPanel()
        {
            cbxCategories.Items.Clear();
            cbxCategories.Text = "";
            cbxSuppliers.Items.Clear();
            cbxSuppliers.Text = "";
            tbBarcode.Text = "";
            tbProductName.Text = "";
            tbProductContent.Text = "";
            btnFrontPic.Text = "Ön Fotoğraf";
            btnBackPic.Text = "Arka Fotoğraf";
            btnAddProductContenPic.Text = "İçerik Fotoğraf";
        }

        private void ChangeDatagridViewsColumnNames(DataGridView colname)
        {
            colname.Columns[0].HeaderText = "ÜrünID";
            colname.Columns[1].HeaderText = "Ürün Adı";
            colname.Columns[2].HeaderText = "Barkod Numarası";
            colname.Columns[3].HeaderText = "Takip Numarası";
            colname.Columns[4].HeaderText = "Onaylandı Mı?";
            colname.Columns[5].HeaderText = "Ön Fotoğraf";
            colname.Columns[6].HeaderText = "Arka Fotoğraf";
            colname.Columns[7].HeaderText = "İçerik Fotoğraf";
            colname.Columns[8].HeaderText = "Ürün İçerikleri";
            colname.Columns[9].HeaderText = "Tedarikçi Adı";
            colname.Columns[10].HeaderText = "Ekleyen Kişi";
            colname.Columns[11].HeaderText = "Kategori Adı";
            colname.Columns[12].HeaderText = "Eklenme Tarihi";
            colname.Columns[13].HeaderText = "Onaylayan Kişi";
            colname.ForeColor = Color.Black;
            foreach (DataGridViewColumn col in colname.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        #endregion
    }
}
