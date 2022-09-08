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
    public partial class Rapor14Form : Form
    {
        public Rapor14Form()
        {
            InitializeComponent();
        }

        string query = "select distinct p.ProductName from Product p "
            + " join ProductFavList f on p.ProductID = f.ProductID "
            + " where MONTH(f.CreatedDate) = MONTH(GETDATE()) and YEAR(f.CreatedDate) = YEAR(GETDATE())";
        private void button1_Click(object sender, EventArgs e)
        {
            List<Rapor14DTO> list = null;
            dataGridView1.DataSource = null;
            using (YesilEvDbContext context = new YesilEvDbContext())
            {

                var result = context.Database.SqlQuery<Rapor14DTO>(query).ToList();

                list = result;
            }

            dataGridView1.DataSource = list;
        }


        string query2 = "select distinct s.SupplementName from Supplement s join SupplementBlackList b on b.SupplementID = s.SupplementID where MONTH(b.CreatedDate) = MONTH(GETDATE()) and YEAR(b.CreatedDate) = YEAR(GETDATE())";
        private void button2_Click(object sender, EventArgs e)
        {
            List<Rapor14DTO2> list = null;
            dataGridView2.DataSource = null;
            using (YesilEvDbContext context = new YesilEvDbContext())
            {

                var result = context.Database.SqlQuery<Rapor14DTO2>(query2).ToList();

                list = result;
            }

            dataGridView2.DataSource = list;
        }
    }
}
