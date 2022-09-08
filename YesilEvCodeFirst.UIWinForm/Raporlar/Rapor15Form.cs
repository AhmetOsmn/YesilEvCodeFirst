using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.DTOs.Rapor;

namespace YesilEvCodeFirst.UIWinForm.Raporlar
{
    public partial class Rapor15Form : Form
    {
        public Rapor15Form()
        {
            InitializeComponent();
        }

        string query1 = "select u.FirstName,  Count(p.ProductName) as UrunSayisi from [User] u join FavList fl on fl.UserID = u.UserID join ProductFavList f on u.UserID = f.FavorID join Product p on f.ProductID = p.ProductID group by u.FirstName";

        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {
            List<Rapor15DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {
                var result = context.Database.SqlQuery<Rapor15DTO>(query1).ToList();

                list = result;
            }

            dataGridView1.DataSource = list;
        }

        string query2 = "select u.FirstName, Count(p.ProductName) as UrunSayisi from [User] u join BlackList b on u.UserID = b.UserID join SupplementBlackList bm on b.BlackListID = bm.BlackListID join ProductSupplement pm on bm.SupplementID = pm.SupplementID join Product p on pm.ProductID = p.ProductID group by u.FirstName";

        private void button1_Click(object sender, EventArgs e)
        {
            List<Rapor15DTO2> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {
                var result = context.Database.SqlQuery<Rapor15DTO2>(query2).ToList();

                list = result;
            }

            dataGridView2.DataSource = list;
        }
    }
}
