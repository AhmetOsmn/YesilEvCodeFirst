using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YesilEvCodeFirst.UIWinForm
{
    public partial class GirisKayitForm : Form
    {
        public GirisKayitForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnGroupBoxKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            GroupBoxKayitOl.Visible = true;
            btnGroupBoxGirisYap.BackColor = System.Drawing.Color.SeaGreen;
            GroupBoxGirisYap.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnGroupBoxGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            GroupBoxGirisYap.Visible = true;
            btnGroupBoxKayitOl.BackColor = System.Drawing.Color.SeaGreen;
            GroupBoxKayitOl.Visible = false;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            UserSayfasi f = new UserSayfasi();
            f.Show();
        }
    }
}
