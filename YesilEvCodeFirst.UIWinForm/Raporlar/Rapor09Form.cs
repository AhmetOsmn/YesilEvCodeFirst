using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.DTOs.Rapor;

namespace YesilEvCodeFirst.UIWinForm.Raporlar
{
    public partial class Rapor09Form : Form
    {
        public Rapor09Form()
        {
            InitializeComponent();
        }

        string query = "select  p.ProductName, Count( distinct b.SupplementID) as AlerjenSayisi from Product p join ProductSupplement pm on p.ProductID = pm.ProductID join SupplementBlackList b on b.SupplementID = pm.SupplementID group by p.ProductName order by AlerjenSayisi desc";
        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {
            List<Rapor09DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {

                var result = context.Database.SqlQuery<Rapor09DTO>(query).ToList();

                list = result;
            }

            dataGridView1.DataSource = list;
            ChangeDatagridViewsColumnNames(dataGridView1);
        }
        private void ChangeDatagridViewsColumnNames(DataGridView colname)
        {
            colname.Columns[0].HeaderText = "Ürün Adı";
            colname.Columns[1].HeaderText = "Alerjen Sayısı";
            colname.ForeColor = Color.Black;
            foreach (DataGridViewColumn col in colname.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
