using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DTOs.Rapor;

namespace YesilEvCodeFirst.UIWinForm.Raporlar
{
    public partial class Rapor05Form : Form
    {
        public Rapor05Form()
        {
            InitializeComponent();
        }

        // comboBox1.Items.Add("Madde Favori/Karaliste Sayısı");
        // select s.SupplementID, Count(distinct f.FavListID) as FavCount ,Count(distinct sb.BlackListID) as BlackCount from Supplement s
        // left outer join[SupplementBlackList] sb on sb.SupplementID = s.SupplementID
        // left outer join ProductSupplement pm on s.SupplementID = pm.SupplementID
        // left outer join ProductFavList f on pm.ProductID = f.ProductID
        // group by s.SupplementID

        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {
            List<Rapor05DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {
                //select s.SupplementName,COUNT(u.FirstName) as 'Kişi Sayısı' from SupplementBlackList sb
                //INNER JOIN Supplement s on sb.SupplementID = s.SupplementID
                //INNER JOIN BlackList b on sb.BlackListID = b.BlackListID
                //inner join[User] u on b.UserID = u.UserID
                //GROUP BY s.SupplementName order by s.SupplementName
            }


            dataGridView1.DataSource = list;
        }
    }
}
