using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.DTOs.Supplier;

namespace YesilEvCodeFirst.UIWinForm
{
    
    public partial class UserSayfasi : Form
    {
        bool sideBarExpand = false;
        public string KullaniciMail;
        UseSupplierDAL SupDAL = new UseSupplierDAL();
        UseCategoryDAL CategoryDAL = new UseCategoryDAL();
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
            btnUrunDuzenle.BackColor = Color.DarkGreen;
            UrunDuzenle.Visible = true;
            btnUrunEkle.BackColor = Color.Green;

        }

        private void UrunEkle_Click(object sender, EventArgs e)
        {
            UrunDuzenle.Visible = false;
            btnUrunEkle.BackColor = Color.DarkGreen;
            UrunEkle.Visible = true;
            btnUrunDuzenle.BackColor = Color.Green;
        }

        private void UrunEkleDuzenle_Click(object sender, EventArgs e)
        {
            Anasayfa.Visible= false;
            UrunEkleDuzenle.Visible = true;
            List<SupplierDTO> suppliers = SupDAL.GetSupplierList();
            List<CategoryDTO> categories = CategoryDAL.GetCategoryList();
            foreach(SupplierDTO item in suppliers)
            {
                cmbBoxUrunEkleUretici.Items.Add(item.SupplierName);
            }
            foreach(CategoryDTO item in categories)
            {
                cmbBoxUrunEkleKategori.Items.Add(item.CategoryName);
            }
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            Anasayfa.Visible = false;
            sideBarKapa();
            UrunEkleDuzenle.Visible = false;
            UserBilgileri.Visible = true;

        }
    }
}
