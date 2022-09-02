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

        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {
            List<Rapor15DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {

            }

            dataGridView1.DataSource = list;
        }
    }
}
