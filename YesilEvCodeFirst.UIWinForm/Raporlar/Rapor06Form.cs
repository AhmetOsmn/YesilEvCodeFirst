using System;
using System.Windows.Forms;

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

        private void buttonRaporuGetir_Click(object sender, EventArgs e)
        {

        }
    }
}
