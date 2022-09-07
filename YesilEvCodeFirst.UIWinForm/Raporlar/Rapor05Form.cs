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

        string query = "select s.SupplementName, Count(distinct f.FavorID) as FavListCount, Count(distinct sb.BlackListID) as BlacListCount from Supplement s left outer join [SupplementBlackList] sb on sb.SupplementID = s.SupplementID left outer join ProductSupplement pm on s.SupplementID = pm.SupplementID left outer join ProductFavList f on pm.ProductID = f.ProductID group by s.SupplementName";
        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {
            List<Rapor05DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {

                var result = context.Database.SqlQuery<Rapor05DTO>(query).ToList();
                    
                list = result;
            }

            dataGridView1.DataSource = list;
            ChangeDatagridViewsColumnNames(dataGridView1);
        }
        private void ChangeDatagridViewsColumnNames(DataGridView colname)
        {
            colname.Columns[0].HeaderText = "Madde Adı";
            colname.Columns[1].HeaderText = "Favori Liste Sayısı";
            colname.Columns[2].HeaderText = "Kara Liste Sayısı";
            colname.ForeColor = Color.Black;
            foreach (DataGridViewColumn col in colname.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
