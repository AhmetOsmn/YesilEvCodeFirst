using System;
using System.Windows.Forms;

using YesilEvCodeFirst.DAL.Use;
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

        private void RaporTuruDoldur()
        {   

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
