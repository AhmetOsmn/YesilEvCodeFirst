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
    public partial class Rapor08Form : Form
    {
        public Rapor08Form()
        {
            InitializeComponent();
        }

        string query = "select top 3 p.ProductName,count(p.ProductName) as 'Eklenme Sayısı' from ProductFavList pf inner join Product p on pf.ProductID=p.ProductID group by p.ProductName order by [Eklenme Sayısı] desc";
        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {
            List<Rapor08DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {

                var result = context.Database.SqlQuery<Rapor08DTO>(query).ToList();

                list = result;
            }

            dataGridView1.DataSource = list;
            ChangeDatagridViewsColumnNames(dataGridView1);
        }
        private void ChangeDatagridViewsColumnNames(DataGridView colname)
        {
            colname.Columns[0].HeaderText = "Ürün Adı";
            colname.ForeColor = Color.Black;
            foreach (DataGridViewColumn col in colname.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
