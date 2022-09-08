using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.DTOs.Rapor;

namespace YesilEvCodeFirst.UIWinForm.Raporlar
{
    public partial class Rapor13Form : Form
    {
        public Rapor13Form()
        {
            InitializeComponent();
        }

        string query = "select top(10) p.ProductName ,  Count(*) as MaddeSayisi from Product p join ProductSupplement pm on p.ProductID = pm.ProductID group by p.ProductName order by MaddeSayisi desc";

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Rapor13DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {

                var result = context.Database.SqlQuery<Rapor13DTO>(query).ToList();

                list = result;
            }

            dataGridView1.DataSource = list;
        }
    }
}
