using NLog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.Supplier;

namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    public partial class UrunIslemleri : Form
    {
        readonly UseProductDAL useProductDAL = new UseProductDAL();
        readonly UseSupplierDAL useSupplierDAL = new UseSupplierDAL();
        readonly UseCategoryDAL useCategoryDAL = new UseCategoryDAL();
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        User currentUser = null;
        GetProductDetailDTO currentProductDTO = null;

        public UrunIslemleri()
        {
            InitializeComponent();
            CloseAllPanels();
            pnlListele.Visible = true;
        }

        #region Group Box 

        private void btnListele_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlListele.Visible = true;
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = useProductDAL.GetProductsForAdmin();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlAra.Visible = true;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            CloseAllPanels();

            pnlApprove.Visible = true;
            dgvApprove.DataSource = null;
            dgvApprove.DataSource = useProductDAL.GetProductsForAdminApprove();
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
        }

        #endregion

        #region Add

        private void btnAddProductContenPic_Click(object sender, EventArgs e)
        {
            FileDialogAddProductContent.ShowDialog();
        }

        private void btnFrontPic_Click(object sender, EventArgs e)
        {
            FileDialogAddProductFront.ShowDialog();
        }

        private void btnBackPic_Click(object sender, EventArgs e)
        {
            FileDialogAddProductBack.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                AddProductDTO addDTO = new AddProductDTO()
                {
                    //AddedBy = currentUser.UserID,
                    AddedBy = 2,
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
            // todo urun guncellerken resim secildiginde hata veriyor bakilacak

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
        }

        private void btnUpdateBackPic_Click(object sender, EventArgs e)
        {
            FileDialogUpdateProductBack.ShowDialog();
        }

        private void btnUpdateFrontPic_Click(object sender, EventArgs e)
        {
            FileDialogUpdateProductFront.ShowDialog();
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            if (isUpdateProductFieldValidator())
            {
                try
                {
                    UpdateProductDTO updateDto = new UpdateProductDTO()
                    {
                        //AddedBy = currentUser.UserID,
                        AddedBy = 2,
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
        }

        #endregion

    }
}
