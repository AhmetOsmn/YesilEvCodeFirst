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
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    public partial class KullaniciIslemleri : Form
    {
        UserDetailDTO user = new UserDetailDTO();
        UseUserDAL useUserDAL = new UseUserDAL();
        public KullaniciIslemleri()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = useUserDAL.GetAllUserDetailForAdmin();
            CloseAllPages();
            pnlListele.Visible = true;
            ChangeDatagridViewsColumnNames(dataGridView1);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            pnlAra.Visible = true;
        }
        public void CloseAllPages()
        {
            pnlAra.Visible = false;
            pnlEkle.Visible = false;
            pnlGuncelle.Visible = false;
            pnlListele.Visible = false;
            pnlSil.Visible = false;
        }

        private void btnSearchUserSearch_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = useUserDAL.GetUserWithFilterForAdmin(txtSearchUserName.Text);
            ChangeDatagridViewsColumnNames(dataGridView2);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            pnlSil.Visible = true;
        }

        private void btnDeleteUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = useUserDAL.DeleteUserWithEmailForAdmin(txtDeleteUserEmail.Text);
                if (result)
                {
                    MessageBox.Show("User silme başarılı");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteUserSearch_Click(object sender, EventArgs e)
        {
            var result = useUserDAL.GetUserWithEmailForAdmin(txtDeleteUserEmail.Text);
            if(result != null)
            {
                txtDeleteUserLastName.Text = result.LastName;
                txtDeleteUserName.Text = result.FirstName;
                txtDeleteUserPhone.Text = result.Phone;
                MessageBox.Show("Silmek istediğiniz Kullanıcı'nın bilgileri doğruysa Sil tuşuna basınız.");
            }
            else
            {
                MessageBox.Show("Yanlış Email");
            }
        }

        private void btnUpdateUserSearch_Click(object sender, EventArgs e)
        {
            var result = useUserDAL.GetUserWithEmailForAdmin(txtUpdateUserEmail.Text);
            if( result != null)
            {
                user.UserID = result.UserID;
                txtUpdateUserLastName.Text = result.LastName;
                txtUpdateUserName.Text = result.FirstName;
                txtUpdateUserPassword.Text = result.Password.ToString();
                txtUpdateUserPhone.Text = result.Phone;
                if(result.RolID == 1)
                {
                    cmbBoxUpdateUserRole.SelectedIndex = 0;
                }
                else
                {
                    cmbBoxUpdateUserRole.SelectedIndex = 1;
                }
                MessageBox.Show("Güncellemek istediğiniz değişiklikleri giriniz");
            }
            else
            {
                MessageBox.Show("Yanlış Email");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            cmbBoxUpdateUserRole.Items.Clear();
            cmbBoxUpdateUserRole.Items.Add("Admin");
            cmbBoxUpdateUserRole.Items.Add("Kullanıcı");
            CloseAllPages();
            pnlGuncelle.Visible= true;
        }

        private void btnUpdateUserUpdate_Click(object sender, EventArgs e)
        {
            UserForAdminDTO updateUser = new UserForAdminDTO()
            {
                UserID = user.UserID,
               Email = txtUpdateUserEmail.Text,
               FirstName = txtUpdateUserName.Text,
               LastName = txtUpdateUserLastName.Text,
               Phone = txtUpdateUserPhone.Text,
               Password = txtUpdateUserPassword.Text, 
           };
            if(cmbBoxUpdateUserRole.SelectedItem == "Admin")
            {
                updateUser.RolID = 1;
            }
            else
            {
                updateUser.RolID = 2;
            }
            try
            {
                useUserDAL.UpdateUserForAdmin(updateUser);
                MessageBox.Show("Başarıyla Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cmbBoxAddUserRole.Items.Clear();
            cmbBoxAddUserRole.Items.Add("Admin");
            cmbBoxAddUserRole.Items.Add("Kullanıcı");
            CloseAllPages();
            pnlEkle.Visible= true;
        }

        private void btnAddUserAdd_Click(object sender, EventArgs e)
        {
            var result = useUserDAL.GetUserWithEmailForAdmin(txtAddUserEmail.Text);
            if(result!= null)
            {
                MessageBox.Show("Bu Email daha önce kullanılmış");
            }
            else
            {
                UserForAdminDTO user = new UserForAdminDTO()
                {
                    Email = txtAddUserEmail.Text,
                    FirstName = txtAddUserName.Text,
                    LastName = txtAddUserLastName.Text,
                    Phone = txtAddUserPhone.Text,
                    Password = txtAddUserPassword.Text,
                };
                if (cmbBoxAddUserRole.SelectedItem == "Admin")
                {
                    user.RolID = 1;
                }
                else
                {
                    user.RolID = 2;
                }
                try
                {
                    bool result1 = useUserDAL.AddUserForAdmin(user);
                    if(result1 != false)
                    {
                        MessageBox.Show("Ekleme İşlemi Başarılı");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
        private void ChangeDatagridViewsColumnNames(DataGridView colname)
        {
            colname.Columns[0].HeaderText = "Kullanıcı ID";
            colname.Columns[1].HeaderText = "Kullanıcı Adı";
            colname.Columns[2].HeaderText = "Kullanıcı Soyadı";
            colname.Columns[3].HeaderText = "Email Adresi";
            colname.Columns[4].HeaderText = "Şifresi";
            colname.Columns[5].HeaderText = "Telefonu";
            colname.Columns[6].HeaderText = "Rolü";
            colname.Columns[7].HeaderText = "Aktif Mi?";
            colname.Columns[8].HeaderText = "Oluşturulma Tarihi";
            colname.Columns[9].HeaderText = "Oluşturan Kişi";
            colname.ForeColor = Color.Black;
            foreach (DataGridViewColumn col in colname.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
