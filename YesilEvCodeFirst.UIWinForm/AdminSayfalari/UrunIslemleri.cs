using System;
using System.Windows.Forms;
using YesilEvCodeFirst.DAL.Use;

namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    public partial class UrunIslemleri : Form
    {
        readonly UseProductDAL useProductDAL = new UseProductDAL();

        public UrunIslemleri()
        {
            InitializeComponent();
            CloseAllPanels();
            pnlListele.Visible = true;

        }

        private void CloseAllPanels()
        {
            pnlListele.Visible = false;
            pnlAra.Visible = false;
            pnlApprove.Visible = false;
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlListele.Visible = true;
            pnlListele.BorderStyle = BorderStyle.Fixed3D;
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = useProductDAL.GetProductsForAdmin();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlAra.BorderStyle = BorderStyle.Fixed3D;
            pnlAra.Visible = true;
        }

        private void btnUrunuAra_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            dgvSearchProduct.DataSource = useProductDAL.GetProductListWithSearchbarForAdmin(tbUrunAra.Text);
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            CloseAllPanels();

            pnlApprove.Visible = true;
            pnlApprove.BorderStyle = BorderStyle.Fixed3D;
            dgvApprove.DataSource = null;
            dgvApprove.DataSource = useProductDAL.GetProductsForAdminApprove();

        }
    }
}
