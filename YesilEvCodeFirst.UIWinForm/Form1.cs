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

namespace YesilEvCodeFirst.UIWinForm
{
    public partial class Form1 : Form
    {
        UseProductDAL use = new UseProductDAL();

        public Form1()
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
        {
            comboBox1.Items.Add("Ürünün Madde Sayısı");
            // select p.ProductName , Count(pm.SupplementID) from Product p join
            // ProductSupplement pm on p.ProductID = pm.ProductID group by p.ProductName
            comboBox1.Items.Add("Maddeyi İçeren Ürünler");
            // select pm.ProductName from Supplement s join ProductSupplement pm
            // on s.SupplementID = pm.SupplementID where s.SupplementID = @sup
            comboBox1.Items.Add("User'a Ait Ürün Sayıları");
            // select u.FirstName , Count(p.ProductName) from User u join Product p
            // on u.UserID = p.EkleyenID group by u.UserID
            comboBox1.Items.Add("Bu Ay Admin Onaysız Ürün Sayısı");
            // select Count(p.ProductName) from Product p where MONTH(p.CreatedDate) = MONTH(GETDATE())
            // and YEAR(p.CreatedDate) = YEAR(GETDATE()) and p.AdminOnay = 0
            comboBox1.Items.Add("Madde Favori/Karaliste Sayısı");
            // select s.SupplementName , Count(*) from Supplement s
            // join ProductSupplement pm on s.SupplementID = pm.SupplementID
            // join FavList f on pm.ProductID = f.ProductID
            // group by s.SupplementName
            comboBox1.Items.Add("En Riskli Ürünler");
            comboBox1.Items.Add("En Favori Ürünler");
            // select p.ProductName ,Count(*) as FavoriSayisi from Product p
            // join FavList f on p.ProductID = f.ProductID order by FavoriSayisi desc
            comboBox1.Items.Add("En Favori Ürünler Toplist3");
            // select top(3) p.ProductName , Count(*) as FavoriSayisi from Product p
            // join FavList f on p.ProductID = f.ProductID group by p.ProductName order by FavoriSayisi desc
            comboBox1.Items.Add("En Çok Alerjen İçeren Ürünler");
            // select  p.ProductName ,  Count( distinct b.SupplementID) as AlerjenSayisi from Product p
            // join ProductSupplement pm on p.ProductID = pm.ProductID
            // join BlackListSupplement b on b.SupplementID = pm.SupplementID
            // group by p.ProductName
            // order by AlerjenSayisi desc
            comboBox1.Items.Add("Riski En Az Olan Ürünler");
            comboBox1.Items.Add("En Çok Riskli Ürün Tutan User Toplist3");
            comboBox1.Items.Add("En Çok Riskli Ürün Ekleyen User Toplist5");
            comboBox1.Items.Add("En Çok Maddesi Olan Ürünler TopList10");
            // select top(10) p.ProductName ,  Count(*) as MaddeSayisi from Product p
            // join ProductSupplement pm on p.ProductID = pm.ProductID
            // group by p.ProductName
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
            comboBox1.Items.Add("User/Admin Sayıları");
            // select r.RolName , Count(u.FirstName) RoleSahipKisi from Role r 
            // join[User] u on r.RolID = u.RolID
            // group by r.RolName

        }
    }
}
