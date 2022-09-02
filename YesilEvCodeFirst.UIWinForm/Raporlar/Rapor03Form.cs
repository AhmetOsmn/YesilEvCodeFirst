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
    public partial class Rapor03Form : Form
    {
        public Rapor03Form()
        {
            InitializeComponent();
        }

        // comboBox1.Items.Add("User'a Ait Ürün Sayıları");
        // select u.FirstName , Count(p.ProductName) from User u join Product p
        // on u.UserID = p.EkleyenID group by u.UserID

        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {
            List<Rapor03DTO> list = null;

            using (YesilEvDbContext context = new YesilEvDbContext()) 
            {
                var result = context.User.Join
                    (
                    context.Product,
                    user => user.UserID,
                    product => product.AddedBy,
                    (user, product) => new
                    {
                        userName = user.FirstName + " " + user.LastName,
                        productID = product.ProductID
                    }).GroupBy(onceki => onceki.userName).Select(grup => new Rapor03DTO
                    {
                        UserName = grup.Key,
                        ProductCount = grup.Select(x => x.productID).Count()
                    }).ToList();

                list = result;
            }

            dataGridView1.DataSource = list;
        }
    }
}
