using System;
using System.Linq;
using System.Windows.Forms;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.UIWinForm
{
    public partial class SignInSignUpForm : Form
    {
        UseUserDAL userDAL = new UseUserDAL();
        public SignInSignUpForm()
        {
            InitializeComponent();
        }

        private void OpenSignUpDetails(object sender, EventArgs e)
        {
            btnGrpBoxSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            GrpBoxSignUp.Visible = true;
            btnGrpBoxSignIn.BackColor = System.Drawing.Color.SeaGreen;
            GrpBoxSignIn.Visible = false;
        }

        private void OpenSignInDetails(object sender, EventArgs e)
        {
            btnGrpBoxSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            GrpBoxSignIn.Visible = true;
            btnGrpBoxSignUp.BackColor = System.Drawing.Color.SeaGreen;
            GrpBoxSignUp.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // todo: buradaki if'ler validatorler ile yapilabilir mi?
            if (txtSignInEmail.Text.Contains('@'))
            {
                if(!string.IsNullOrEmpty(txtSignInPassword.Text))
                {
                    LoginDTO dto = new LoginDTO()
                    {
                        Email = txtSignInEmail.Text,
                        Password = txtSignInPassword.Text,
                    };
                    var result = userDAL.UserLogin(dto);
                    if (result == null)
                    {
                        MessageBox.Show("Giriş Bilgileri Yanlış");
                    }
                    else
                    {
                        OpenUserPage(result);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen şifre giriniz.");
                }

            }
            else if (string.IsNullOrEmpty(txtSignInEmail.Text))
            {
                MessageBox.Show("Lütfen email giriniz.");
            }
            else
            {
                MessageBox.Show("Girilen Email Hatalıdır.");
            }

        }
        private void OpenUserPage(UserDetailDTO result)
        {
            UserSayfasi f = new UserSayfasi();
            f.User = result;
            this.Hide();
            f.ShowDialog();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            btnSignUp.Enabled = false;
            if (txtEmail.Text.Contains('@'))
            {
                AddUserDTO dto = new AddUserDTO()
                {
                    Email = txtEmail.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Password = txtPassword.Text,
                    Phone = "1234567891"
                };
                var result = userDAL.AddUser(dto);
                if (result)
                {
                    MessageBox.Show("Başarıyla Kayıt Oldunuz. Giriş Yapabilirsiniz");
                    GrpBoxSignUp.Visible = false;
                    GrpBoxSignIn.Visible = true;
                }
            }
        }
    }
}
