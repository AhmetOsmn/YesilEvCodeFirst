using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.SearchHistory;
using YesilEvCodeFirst.DTOs.Supplier;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.UIWinForm
{

    public partial class UserSayfasi : Form
    {
        bool isAddProduct = false;
        bool isUpdatable = false;
        bool sideBarExpand = false;
        string frontPic = "";
        string backPic = "";
        public UserDetailDTO Kullanici;
        UseSupplierDAL SupDAL = new UseSupplierDAL();
        UseCategoryDAL CategoryDAL = new UseCategoryDAL();
        UseProductDAL ProductDAL = new UseProductDAL();
        UseSearchHistoryDAL searchHistoryDAL = new UseSearchHistoryDAL();
        GetProductDetailDTO dto = null;

        public UserSayfasi()
        {
            InitializeComponent();
            sideBarKapa();
            UrunEkleDuzenle.Visible = false;
            UserBilgileri.Visible = false;
            AramaGecmisi.Visible = false;
            UrunArama.Visible = false;
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
            AramaGecmisi.Visible = false;
            sideBarKapa();
            Anasayfa.Visible = true;
            UserBilgileri.Visible = false;
            UrunArama.Visible = false;
        }

        private void UrunDuzenle_Click(object sender, EventArgs e)
        {
            UrunEkle.Visible = false;
            isAddProduct = false;
            btnUrunDuzenle.BackColor = Color.DarkGreen;
            UrunDuzenle.Visible = true;
            btnUrunEkle.BackColor = Color.Green;
            isAddProduct = false;
            Clean();
        }

        private void UrunEkle_Click(object sender, EventArgs e)
        {
            UrunDuzenle.Visible = false;
            isAddProduct = true;
            btnUrunEkle.BackColor = Color.DarkGreen;
            UrunEkle.Visible = true;
            btnUrunDuzenle.BackColor = Color.Green;
            isAddProduct = true;
            Clean();
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
            UrunArama.Visible = false;
            sideBarKapa();
            UrunEkleDuzenle.Visible = false;
            AramaGecmisi.Visible = false;
            UserBilgileri.Visible = true;
            lblUyelikTarihiValue.Text = Kullanici.CreatedDate.ToString();
            lblUserName.Text = Kullanici.FirstName + " " + Kullanici.LastName;
            lblEkledigiUrunSayisi.Text += " "+ProductDAL.GetProductListWithUserID(Kullanici.UserID).Count.ToString();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            btnGonder.Enabled = false;
            UseProductDAL dal = new UseProductDAL();
            if(isAddProduct)
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
                        PictureFronthPath = openFileDialog3.FileName,
                        PictureBackPath = openFileDialog4.FileName,
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
            }
            else
            {
                if(isUpdatable)
                {
                    if (isUpdateProductFieldValidator())
                    {
                        UpdateProductDTO updateDto = new UpdateProductDTO()
                        {
                            AddedBy = Kullanici.UserID,
                            Barcode = txtBarkodNo.Text,
                            SupplierID = ((CategoryDTO)cmbBoxKategori.SelectedItem).CategoryID,
                            ProductName = txtUrunAdi.Text,
                            CategoryID = ((SupplierDTO)cmbBoxUretici.SelectedItem).SupplierID,
                            PictureBackPath = openFileDialog2.FileName,
                            PictureFronthPath = openFileDialog1.FileName,
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
            if(txtBarkodNo.Text != ""&& txtBarkodNo.Text.Length==7)
            {
                dto = ProductDAL.GetProductDetailWithBarcode(txtBarkodNo.Text);
                if(dto != null)
                {
                    if(dto.AddedBy == Kullanici.UserID)
                    {
                        txtBarkodNo.Text = dto.Barcode;
                        cmbBoxUretici.SelectedIndex = cmbBoxUretici.FindString(dto.SupplierName);
                        txtUrunAdi.Text = dto.ProductName;
                        txtUrunIcerik.Text = dto.ProductContent;
                        cmbBoxKategori.SelectedIndex = cmbBoxKategori.FindString(dto.CategoryName);
                        openFileDialog1.FileName = dto.PictureFronthPath;
                        openFileDialog2.FileName = dto.PictureBackPath;
                        var item = dto.PictureFronthPath.Split('\\');
                        btnOnYuz.Text = item[item.Length-1];
                        item = dto.PictureBackPath.Split('\\');
                        btnArkaYuz.Text = item[item.Length-1];
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
            else if(txtBarkodNo.Text == "")
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
        
        /// <summary>
        ///  Arama yapan kisinin ismini, aranan urunu ve arama tarihini gosteriyor.
        /// </summary>

        private void btnAramaGecmisiFavori_Click(object sender, EventArgs e)
        {
            AramaGecmisi.Visible = true;
            Anasayfa.Visible = false;
            dataGridView1.DataSource = searchHistoryDAL.GetSearchHistoryListWithUserID(Kullanici.UserID);
        }

        private void GecmisiTemizle(object sender, EventArgs e)
        {
            searchHistoryDAL.ClearSearchHistoryWithUserID(Kullanici.UserID);
            MessageBox.Show("Arama geçmişi temizlendi!");
            dataGridView1.DataSource = null;
        }
        
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnOnYuz.Text = openFileDialog1.SafeFileName;
        }
        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnArkaYuz.Text = openFileDialog2.SafeFileName;
        }
        private void openFileDialog3_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnUrunEkleOnYuz.Text = openFileDialog3.SafeFileName;
        }
        private void openFileDialog4_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btnUrunEkleArkaYuz.Text = openFileDialog4.SafeFileName;
        }
        private void btnOnYuz_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void btnArkaYuz_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }
        private void btnUrunEkleOnYuz_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }
        private void btnUrunEkleArkaYuz_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
        }

        private bool isAddProductFieldValidator()
        {
            if (string.IsNullOrEmpty(txtUrunEkleBarkod.Text))
            {
                MessageBox.Show("Ürün barcode boş olamaz.");
                return false;
            }
            else if(string.IsNullOrEmpty(txtUrunEkleUrunAdi.Text))
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
            else if(string.IsNullOrEmpty(txtUrunEkleUrunIcerik.Text)){
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
            UrunArama.Visible = true;
            Anasayfa.Visible = false;

        }

        private void btnSearchbarAra_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtAramaSearchbar.Text.Trim()))
            {
                string aranacak = txtAramaSearchbar.Text;
                var result = ProductDAL.GetProductListForSearchbar(aranacak);
                dataGridViewProducts.DataSource = result;

            }
            else
            {
                MessageBox.Show("Lütfen harf veya kelime giriniz!");
            }
          
        }

        private void dataGridViewProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedProductID = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value);

                searchHistoryDAL.AddSearchHistory(new AddSearchHistoryDTO
                {
                    UserID = Kullanici.UserID,
                    ProductID = selectedProductID,
                });

                var result = ProductDAL.GetProductDetailWithID(selectedProductID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
