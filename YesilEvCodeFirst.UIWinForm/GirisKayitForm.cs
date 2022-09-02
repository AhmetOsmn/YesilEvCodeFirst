using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.UIWinForm
{
    public partial class GirisKayitForm : Form
    {
        UseUserDAL userDAL = new UseUserDAL();
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
            // todo: buradaki if'ler validatorler ile yapilabilir mi?
            if (txtGirisYapEmail.Text.Contains('@'))
            {
                if(!string.IsNullOrEmpty(txtGirisYapSifre.Text))
                {
                    LoginDTO dto = new LoginDTO()
                    {
                        Email = txtGirisYapEmail.Text,
                        Password = txtGirisYapSifre.Text,
                    };
                    var result = userDAL.UserLogin(dto);
                    if (result == null)
                    {
                        MessageBox.Show("Giriş Bilgileri Yanlış");
                    }
                    else
                    {
                        UserSayfasiAc(result);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen şifre giriniz.");
                }
                
            }
            else if (string.IsNullOrEmpty(txtGirisYapEmail.Text))
            {
                MessageBox.Show("Lütfen email giriniz.");
            }
            else
            {
                MessageBox.Show("Girilen Email Hatalıdır.");
            }
        }
        private void UserSayfasiAc(UserDetailDTO result)
        {
            UserSayfasi f = new UserSayfasi();
            f.Kullanici = result;
            this.Hide();
            f.ShowDialog();
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            btnKayitOl.Enabled = false;
            if (txtEmail.Text.Contains('@'))
            {
                AddUserDTO dto = new AddUserDTO()
                {
                    Email = txtEmail.Text,
                    FirstName = txtIsim.Text,
                    LastName = txtSoyisim.Text,
                    Password = txtSifre.Text,
                    Phone = "1234567891"
                };
                var result = userDAL.AddUser(dto);
                if (result)
                {
                    MessageBox.Show("Başarıyla Kayıt Oldunuz. Giriş Yapabilirsiniz");
                    GroupBoxKayitOl.Visible = false;
                    GroupBoxGirisYap.Visible = true;
                }
            }
        }
    }
}
