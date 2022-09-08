using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.DTOs.Rapor;

namespace YesilEvCodeFirst.UIWinForm.Raporlar
{
    public partial class Rapor06Form : Form
    {
        public Rapor06Form()
        {
            InitializeComponent();
        }

        // select p.ProductName , Count(*) as FavoriSayisi from Product p
        // join FavList f on p.ProductID = f.ProductID order by FavoriSayisi desc

        string query = "select p.ProductName, case when s.RiskRatio = 2 then 'Orta Riskli' when s.RiskRatio = 3 then 'Çok riskli' end as RiskRatio from ProductSupplement ps inner join Product p on ps.ProductID = p.ProductID inner join Supplement s on ps.SupplementID = s.SupplementID group by p.ProductName,s.RiskRatio Having s.RiskRatio>=2 order by s.RiskRatio desc";
        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {
            List<Rapor06DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {

                var result = context.Database.SqlQuery<Rapor06DTO>(query).ToList();

                list = result;
            }

            dataGridView1.DataSource = list;
            ChangeDatagridViewsColumnNames(dataGridView1);
        }
        private void ChangeDatagridViewsColumnNames(DataGridView colname)
        {
            colname.Columns[0].HeaderText = "Ürün Adı";
            colname.Columns[1].HeaderText = "Risk Seviyesi";
            colname.ForeColor = Color.Black;
            foreach (DataGridViewColumn col in colname.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
