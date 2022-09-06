using FluentValidation.Results;
using System;
using System.Linq;
using System.Windows.Forms;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.UserAdmin;
using YesilEvCodeFirst.Validation.FluentValidator;

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
            LoginDTO dto = new LoginDTO()
            {
                Email = txtSignInEmail.Text,
                Password = txtSignInPassword.Text,
            };
            try
            {
                var result = userDAL.UserLogin(dto);
                OpenUserPage(result);
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            //to do dialog result kullanıcı mevcut giriş sayfasına gitmek ister misin?
            btnSignUp.Enabled = false;
            AddUserDTO dto = new AddUserDTO()
            {
                Email = txtEmail.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Password = txtPassword.Text,
                Phone = "1234567891"
            };
            try
            {
                var result = userDAL.AddUser(dto);
                if (result)
                {
                    MessageBox.Show("Başarıyla Kayıt Oldunuz. Giriş Yapabilirsiniz.");
                    GrpBoxSignUp.Visible = false;
                    GrpBoxSignIn.Visible = true;
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
                btnSignUp.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnSignUp.Enabled = true;
            }
        }
    }
}
