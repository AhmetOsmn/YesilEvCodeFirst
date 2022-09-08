using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.DTOs.Rapor;

namespace YesilEvCodeFirst.UIWinForm.Raporlar
{
    public partial class Rapor12Form : Form
    {
        public Rapor12Form()
        {
            InitializeComponent();
        }

        string query = "select top(5) u.FirstName, u.Email, COUNT(p.ProductID) UrunSayisi from [User] u join Product p on p.AddedBy =  u.UserID group by  u.FirstName, u.Email order by UrunSayisi desc";
        private void button1_Click(object sender, EventArgs e)
        {
            List<Rapor12DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {

                var result = context.Database.SqlQuery<Rapor12DTO>(query).ToList();

                list = result;
            }

            dataGridView1.DataSource = list;
        }
    }
}
