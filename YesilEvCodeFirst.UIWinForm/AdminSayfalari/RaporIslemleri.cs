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
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.UIWinForm.Raporlar;

namespace YesilEvCodeFirst.UIWinForm
{
    public partial class RaporIslemleri : Form
    {
        UseProductDAL use = new UseProductDAL();

        public RaporIslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    List<ListProductDTO> products = new List<ListProductDTO>();
            //    products = use.GetProductList();
            //    List<RaporProductDTO> rapor = new List<RaporProductDTO>();
            //    foreach(var product in products)
            //    {

            //        var str = product.ProductContent.Split(',');
            //        rapor.Add(new RaporProductDTO()
            //        {
            //            ProductName = product.ProductName,
            //            SupplementCount = str.Length
            //        }) ;
            //    }

            //    dataGridView1.DataSource = rapor;
        }
        private void RaporTuruDoldur()
        {   //1
            comboBox1.Items.Add("Ürünün Madde Sayısı");
            // select p.ProductName , Count(pm.SupplementID) from Product p join
            // ProductSupplement pm on p.ProductID = pm.ProductID group by p.ProductName
            
            //2
            comboBox1.Items.Add("Maddeyi İçeren Ürünler");
            // select pm.ProductName from Supplement s join ProductSupplement pm
            // on s.SupplementID = pm.SupplementID where s.SupplementID = @sup
            
            //3
            comboBox1.Items.Add("User'a Ait Ürün Sayıları");
            // select u.FirstName , Count(p.ProductName) from User u join Product p
            // on u.UserID = p.EkleyenID group by u.UserID
            
            //4
            comboBox1.Items.Add("Bu Ay Admin Onaysız Ürün Sayısı");
            // select Count(p.ProductName) from Product p where MONTH(p.CreatedDate) = MONTH(GETDATE())
            // and YEAR(p.CreatedDate) = YEAR(GETDATE()) and p.AdminOnay = 0
            
            //5
            comboBox1.Items.Add("Madde Favori/Karaliste Sayısı");
            // select s.SupplementName , Count(*) from Supplement s
            // join ProductSupplement pm on s.SupplementID = pm.SupplementID
            // join FavList f on pm.ProductID = f.ProductID
            // group by s.SupplementName
            
            //6
            comboBox1.Items.Add("En Riskli Ürünler");
            
            //7
            comboBox1.Items.Add("En Favori Ürünler");
            // select p.ProductName ,Count(*) as FavoriSayisi from Product p
            // join FavList f on p.ProductID = f.ProductID order by FavoriSayisi desc
            
            //8
            comboBox1.Items.Add("En Favori Ürünler Toplist3");
            // select top(3) p.ProductName , Count(*) as FavoriSayisi from Product p
            // join FavList f on p.ProductID = f.ProductID group by p.ProductName order by FavoriSayisi desc
            
            //9
            comboBox1.Items.Add("En Çok Alerjen İçeren Ürünler");
            // select  p.ProductName ,  Count( distinct b.SupplementID) as AlerjenSayisi from Product p
            // join ProductSupplement pm on p.ProductID = pm.ProductID
            // join BlackListSupplement b on b.SupplementID = pm.SupplementID
            // group by p.ProductName
            // order by AlerjenSayisi desc
            
            //10
            comboBox1.Items.Add("Riski En Az Olan Ürünler");
            
            //11
            comboBox1.Items.Add("En Çok Riskli Ürün Tutan User Toplist3");
            
            //12
            comboBox1.Items.Add("En Çok Riskli Ürün Ekleyen User Toplist5");
            
            //13
            comboBox1.Items.Add("En Çok Maddesi Olan Ürünler TopList10");
            // select top(10) p.ProductName ,  Count(*) as MaddeSayisi from Product p
            // join ProductSupplement pm on p.ProductID = pm.ProductID
            // group by p.ProductName
            
            //14
            comboBox1.Items.Add("Bu Ay Favori/Karaliste'ye Eklenen Ürünler");
            ////Favori
            // select distinct p.ProductName from Product p
            // join FavList f on p.ProductID = f.ProductID
            // where MONTH(f.CreatedDate) = MONTH(GETDATE()) and YEAR(f.CreatedDate) = YEAR(GETDATE())
            ////KaraListe
            // select distinct p.ProductName from Product p
            // join ProductSupplement pm on p.ProductID = pm.ProductID
            // join BlackListSupplement b on b.SupplementID = pm.SupplementID
            // where MONTH(b.CreatedDate) = MONTH(GETDATE()) and YEAR(b.CreatedDate) = YEAR(GETDATE())
            
            //15
            comboBox1.Items.Add("User Favori/Karaliste Ürün Sayısı");
            //// Favori ürün sayısı
            // select u.FirstName , f.FavorID , Count(p.ProductName) from User u 
            // join FavList f on u.UserID = f.UserID 
            // join Product p on f.ProductID = p.ProductID
            // group by f.FavoriID
            //// KaraListe ürün sayısı
            // select u.FirstName , b.BlackListID , Count(p.ProductName) as UrunSayisi from [User] u
            // join BlackList b on u.CustomerID = b.UserID
            // join BlackListSupplement bm on b.BlackListID = bm.BlackListID
            // join ProductSupplement pm on bm.SupplementID = pm.SupplementID
            // join Product p on pm.ProductID = p.ProductID
            // group by b.BlackListID , u.FirstName
            
            //16
            comboBox1.Items.Add("User/Admin Sayıları");
            // select r.RolName , Count(u.FirstName) RoleSahipKisi from Role r 
            // join[User] u on r.RolID = u.RolID
            // group by r.RolName

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem)
            {
                case "Rapor 1":
                    OpenChildForm(new Rapor01Form());
                    break;
                case "Rapor 2":
                    OpenChildForm(new Rapor02Form());
                    break;

                case "Rapor 3":
                    OpenChildForm(new Rapor03Form());
                    break;

                case "Rapor 4":
                    OpenChildForm(new Rapor04Form());
                    break;

                case "Rapor 5":
                    OpenChildForm(new Rapor05Form());
                    break;

                case "Rapor 6":
                    OpenChildForm(new Rapor06Form());
                    break;

                case "Rapor 7":
                    OpenChildForm(new Rapor07Form());
                    break;

                case "Rapor 8":
                    OpenChildForm(new Rapor08Form());
                    break;

                case "Rapor 9":
                    OpenChildForm(new Rapor09Form());
                    break;

                case "Rapor 10":
                    OpenChildForm(new Rapor10Form());
                    break;

                case "Rapor 11":
                    OpenChildForm(new Rapor11Form());
                    break;

                case "Rapor 12":
                    OpenChildForm(new Rapor12Form());
                    break;

                case "Rapor 13":
                    OpenChildForm(new Rapor13Form());
                    break;

                case "Rapor 14":
                    OpenChildForm(new Rapor14Form());
                    break;

                case "Rapor 15":
                    OpenChildForm(new Rapor15Form());
                    break;

                case "Rapor 16":
                    OpenChildForm(new Rapor16Form());
                    break;

                default:
                    break;
            }
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
