using System.Drawing;
using System.Windows.Forms;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    public partial class AdminSayfasi : Form
    {
        public UserDetailDTO User; 
        public AdminSayfasi()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.BackColor = Color.LightGray;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void tsProduct_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new UrunIslemleri());
        }

        private void tsSupplement_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new MaddeIslemleri());
        }

        private void tsCategory_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new KategoriIslemleri());
        }

        private void tsSupplier_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new UreticiIslemleri());
        }

        private void tsUser_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new KullaniciIslemleri());
        }

        private void tsRapor_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new RaporIslemleri());
        }
    }
}
