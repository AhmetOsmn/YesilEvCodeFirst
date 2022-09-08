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
    public partial class Rapor16Form : Form
    {
        public Rapor16Form()
        {
            InitializeComponent();
        }

        string query = "select r.RolName as Rol , Count(u.FirstName) Sayi from Role r  join [User] u on r.RolID = u.RolID  group by r.RolName";

        private void button1_Click(object sender, EventArgs e)
        {
            List<Rapor16DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {

                var result = context.Database.SqlQuery<Rapor16DTO>(query).ToList();

                list = result;
            }

            dataGridView1.DataSource = list;
        }
    }
}
