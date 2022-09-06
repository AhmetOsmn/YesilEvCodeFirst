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
        readonly UseCategoryDAL useCategoryDAL= new UseCategoryDAL();

        User currentUser = null;
        GetProductDetailDTO currentProductDTO = null;

        public UrunIslemleri()
        {
            InitializeComponent();
            CloseAllPanels();
            pnlListele.Visible = true;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlListele.Visible = true;
            pnlListele.BorderStyle = BorderStyle.Fixed3D;
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = useProductDAL.GetProductsForAdmin();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlAra.BorderStyle = BorderStyle.Fixed3D;
            pnlAra.Visible = true;
        }

        private void btnUrunuAra_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            dgvSearchProduct.DataSource = useProductDAL.GetProductListWithSearchbarForAdmin(tbUrunAra.Text);
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            CloseAllPanels();

            pnlApprove.Visible = true;
            pnlApprove.BorderStyle = BorderStyle.Fixed3D;
            dgvApprove.DataSource = null;
            dgvApprove.DataSource = useProductDAL.GetProductsForAdminApprove();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlUrunEkle.Visible = true;
            pnlUrunEkle.BorderStyle = BorderStyle.Fixed3D;
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
                }
                EnableUpdateElements();
            }
            catch(FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlUrunGuncelle.Visible = true;
            pnlUrunGuncelle.BorderStyle = BorderStyle.Fixed3D;
        }

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

            if (tbUpdateBarcode.Text == currentProductDTO.Barcode &&
                tbUpdateProductName.Text == currentProductDTO.ProductName &&
                tbUpdateProductContent.Text == currentProductDTO.ProductContent &&
                ((CategoryDTO)cbxUpdateCategories.SelectedItem).CategoryID == currentProductDTO.CategoryID &&
                ((SupplierDTO)cbxUpdateSuppliers.SelectedItem).SupplierID == currentProductDTO.SupplierID)
                //btnAddAndUpdateProductUpdateProductFront.Text == frontpicture &&
                //btnAddAndUpdateProductUpdateProductBack.Text == backpicture)
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
            tbDeleteProductName.Text = "";
            tbDeleteProductContent.Text = "";
            tbDeleteSupplement.Text = "";
            tbDeleteCategory.Text = "";
            tbDeleteBarcode.Text = "";
            tbDeleteAdder.Text = "";
        }

        #endregion

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
                        CategoryID = ((CategoryDTO)cbxUpdateCategories.SelectedItem).CategoryID,
                        ProductName = tbUpdateProductName.Text,
                        SupplierID = ((SupplierDTO)cbxUpdateSuppliers.SelectedItem).SupplierID,
                        //PictureBackPath = FileDialogUpdateProductBack.FileName,
                        //PictureFronthPath = FileDialogUpdateProductFront.FileName,
                        ProductContent = tbUpdateProductContent.Text
                    };
                    bool result = useProductDAL.UpdateProduct(updateDto);
                    if (result)
                    {
                        MessageBox.Show("Ürün Güncellendi");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                AddProductDTO addDTO = new AddProductDTO()
                {
                    //AddedBy = currentUser.UserID,
                    AddedBy = 2,
                    Barcode = tbBarcode.Text,
                    CategoryID = ((CategoryDTO)cbxCategories.SelectedItem).CategoryID,
                    ProductName = tbProductName.Text,
                    SupplierID = ((SupplierDTO)cbxSuppliers.SelectedItem).SupplierID,
                    //PictureBackPath = FileDialogUpdateProductBack.FileName,
                    //PictureFronthPath = FileDialogUpdateProductFront.FileName,
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

        private void btnDeleteSearch_Click(object sender, EventArgs e)
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

        private void btnDeleteDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show("Emin misiniz?","Ürün Sil",MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                BarcodeDTO barcodeDTO = new BarcodeDTO { Barcode = tbDeleteBarcode.Text };
                useProductDAL.DeleteProduct(barcodeDTO);
                MessageBox.Show("Ürün silindi!");
                ClearDeleteProductPanel();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlDeleteProduct.BorderStyle = BorderStyle.Fixed3D;
            pnlDeleteProduct.Visible = true;
        }
    }
}
