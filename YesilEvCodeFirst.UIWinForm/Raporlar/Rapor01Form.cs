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
    public partial class Rapor01Form : Form
    {
        public Rapor01Form()
        {
            InitializeComponent();
        }

        // comboBox1.Items.Add("Ürünün Madde Sayısı");
        // select p.ProductName , Count(pm.SupplementID) from Product p join
        // ProductSupplement pm on p.ProductID = pm.ProductID group by p.ProductName

        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {
            List<Rapor01DTO> list = null;
            using (YesilEvDbContext context = new YesilEvDbContext())
            {
                var result = context.Product.Join
                    (
                    context.ProductSupplement,
                    product => product.ProductID,
                    ps => ps.ProductID, 
                    (p, ps) => new
                    {
                        productName = p.ProductName,
                        supplementID = ps.SupplementID
                    }).GroupBy(onceki => onceki.productName).Select(grup => new Rapor01DTO
                    {
                        ProductName = grup.Key,
                        SupplementCount = grup.Select(x => x.supplementID).Count()
                    }).ToList();

                list = result;
            }

            dataGridView1.DataSource = list;

        }
    }
}
