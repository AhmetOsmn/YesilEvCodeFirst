using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.Supplier;

namespace YesilEvCodeFirst.UIWinForm
{

    public partial class UserSayfasi : Form
    {
        bool isAddProduct = false;
        bool isUpdatable = false;
        bool sideBarExpand = false;
        string frontPic = "";
        string backPic = "";
        public string KullaniciMail;
        UseSupplierDAL SupDAL = new UseSupplierDAL();
        UseCategoryDAL CategoryDAL = new UseCategoryDAL();
        UseProductDAL ProductDAL = new UseProductDAL();
        public UserSayfasi()
        {
            InitializeComponent();
            sideBarKapa();
            UrunEkleDuzenle.Visible = false;
            UserBilgileri.Visible = false;
            Anasayfa.Visible = true;
            SideBar.Visible = true;
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
            UrunEkleDuzenle.Visible = false;
            sideBarKapa();
            Anasayfa.Visible = true;
            UserBilgileri.Visible = false;
        }

        private void UrunDuzenle_Click(object sender, EventArgs e)
        {
            UrunEkle.Visible = false;
            isAddProduct = false;
            btnUrunDuzenle.BackColor = Color.DarkGreen;
            UrunDuzenle.Visible = true;
            btnUrunEkle.BackColor = Color.Green;
            isAddProduct = false;
        }

        private void UrunEkle_Click(object sender, EventArgs e)
        {
            UrunDuzenle.Visible = false;
            isAddProduct = true;
            btnUrunEkle.BackColor = Color.DarkGreen;
            UrunEkle.Visible = true;
            btnUrunDuzenle.BackColor = Color.Green;
            isAddProduct = true;
        }

        private void UrunEkleDuzenle_Click(object sender, EventArgs e)
        {
            Anasayfa.Visible= false;
            UrunEkleDuzenle.Visible = true;
            List<SupplierDTO> suppliers = SupDAL.GetSupplierList();
            List<CategoryDTO> categories = CategoryDAL.GetCategoryList();
            foreach(SupplierDTO item in suppliers)
            {
                cmbBoxUrunEkleUretici.Items.Add(item);
                cmbBoxUretici.Items.Add(item);
            }
            foreach(CategoryDTO item in categories)
            {
                cmbBoxUrunEkleKategori.Items.Add(item);
                cmbBoxKategori.Items.Add(item);
            }
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            Anasayfa.Visible = false;
            sideBarKapa();
            UrunEkleDuzenle.Visible = false;
            UserBilgileri.Visible = true;

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            btnGonder.Enabled = false;
            UseProductDAL dal = new UseProductDAL();
            if(isAddProduct)
            {
                bool result = dal.AddProduct(new AddProductDTO
                {
                    Barcode = txtUrunEkleBarkod.Text,
                    SupplierID = ((CategoryDTO)cmbBoxUrunEkleKategori.SelectedItem).CategoryID,
                    ProductName = txtUrunEkleUrunAdi.Text,
                    CategoryID = ((SupplierDTO)cmbBoxUrunEkleUretici.SelectedItem).SupplierID,
                    ProductContent = txtUrunEkleUrunIcerik.Text,

                    //to do file dialog get path
                    PictureFronthPath = "test",
                    PictureBackPath = "test",
                });
                if (result)
                {
                    MessageBox.Show("Ürün Eklendi");
                    txtUrunEkleBarkod.Text = "";
                    txtUrunEkleUrunAdi.Text = "";
                    txtUrunEkleUrunIcerik.Text = "";
                    cmbBoxUrunEkleKategori.Text = "";
                    cmbBoxUrunEkleUretici.Text = "";  
                }
                else
                {
                    MessageBox.Show("Ürün zaten mevcutta var");
                }
            }
            else
            {
                if(isUpdatable)
                {
                    UpdateProductDTO updateDto = new UpdateProductDTO() {
                        Barcode = txtBarkodNo.Text,
                        SupplierID = ((CategoryDTO)cmbBoxKategori.SelectedItem).CategoryID,
                        ProductName = txtUrunAdi.Text,
                        CategoryID = ((SupplierDTO)cmbBoxUretici.SelectedItem).SupplierID,
                        PictureBackPath = "test",
                        PictureFronthPath = "test",
                        ProductContent = txtUrunIcerik.Text
                    };
                    bool result = dal.UpdateProduct(updateDto);
                    if (result)
                    {
                        MessageBox.Show("Ürün Güncellendi");
                        txtBarkodNo.Text = "";
                        txtUrunAdi.Text = "";
                        txtUrunIcerik.Text = "";
                        cmbBoxKategori.Text = "";
                        cmbBoxUretici.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ürün bulunamadı");
                    }
                }
                else
                {
                    MessageBox.Show("Barkod kullanarak ürünü getirin.");
                }
            }
            btnGonder.Enabled = true;
        }

        private void btnUrunEkleOnYuz_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog
            {
                Title = "Open Image file",
                Filter = "JPG Files (*.jpg)| *.jpg | PNG Files (*.png) | *.png"
            };

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileOpen.FileName;
                frontPic = Path.GetFullPath(fileName);
            }
            fileOpen.Dispose();
        }

        private void btnUrunGetir_Click(object sender, EventArgs e)
        {
            if(txtBarkodNo.Text != ""&& txtBarkodNo.Text.Length==7)
            {
                GetProductDetailDTO dto = ProductDAL.GetProductDetailWithBarcode(txtBarkodNo.Text);
                if(dto != null)
                {
                    txtBarkodNo.Text = dto.Barcode;
                    cmbBoxUretici.Text = dto.SupplierName;
                    txtUrunAdi.Text = dto.ProductName;
                    txtUrunIcerik.Text = dto.ProductContent;
                    cmbBoxKategori.Text = dto.CategoryName;
                    //to do path to get file function
                }
            }
            isUpdatable = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
