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
    public partial class Rapor02Form : Form
    {
        public Rapor02Form()
        {
            InitializeComponent();
        }

        // comboBox1.Items.Add("Maddeyi İçeren Ürünler");
        // select pm.ProductName from Supplement s join ProductSupplement pm
        // on s.SupplementID = pm.SupplementID where s.SupplementID = @sup

        private void button1_Click(object sender, EventArgs e)
        {
            List<Rapor02DTO> list = null;
            string aranan = textBox1.Text;
            using (YesilEvDbContext context = new YesilEvDbContext())
            {
                var result = context.Supplement.Join
                    (
                        context.ProductSupplement,
                        supplement => supplement.SupplementID,
                        ps => ps.SupplementID,
                        (supplement, ps) => new
                        {
                            supplementID = supplement.SupplementID,
                            productID = ps.ProductID,
                            supplementName = supplement.SupplementName,
                            productName = ps.Product.ProductName
                        }
                    ).Where(onceki => onceki.supplementName.ToLower().Equals(aranan.ToLower()))
                    .Select(onceki => new Rapor02DTO
                    {
                        ProductName = onceki.productName
                    }).ToList();

                list = result;
            }

            dataGridView1.DataSource = list;
        }
    }
}
