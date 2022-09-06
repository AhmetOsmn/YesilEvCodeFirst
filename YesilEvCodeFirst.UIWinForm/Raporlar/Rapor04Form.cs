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
    public partial class Rapor04Form : Form
    {
        public Rapor04Form()
        {
            InitializeComponent();
        }

        // comboBox1.Items.Add("Bu Ay Admin Onaysız Ürün Sayısı");
        // select Count(p.ProductName) from Product p where MONTH(p.CreatedDate) = MONTH(GETDATE())
        // and YEAR(p.CreatedDate) = YEAR(GETDATE()) and p.AdminOnay = 0

        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {
            List<Rapor04DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext())
            {
                var result = context.Product
                    //.Where(p => p.IsApproved == false && (DateTime.Now.AddDays(-30) > p.CreatedDate))
                    .Where(p => p.IsApproved == false && DateTime.Now.Year == p.CreatedDate.Year && DateTime.Now.Month == p.CreatedDate.Month)
                    .Select(x => new Rapor04DTO
                    {
                        Barcode = x.Barcode,
                        ProductName = x.ProductName
                    }).ToList();

                list = result;
            }
            labelUrunSayisi.Text = list.Count().ToString();
            dataGridView1.DataSource = list;
        }

    }
}
