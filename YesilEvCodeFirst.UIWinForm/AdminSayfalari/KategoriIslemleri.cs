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
using YesilEvCodeFirst.DTOs.Category;

namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    public partial class KategoriIslemleri : Form
    {
        UseCategoryDAL useCategoryDAL = new UseCategoryDAL();
        public KategoriIslemleri()
        {
            InitializeComponent();
        }

        private void CloseAllPages()
        {
            pnlAra.Visible = false;
            pnlEkle.Visible = false;
            pnlGuncelle.Visible = false;
            pnlListele.Visible = false;
            pnlSil.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            var result = useCategoryDAL.GetCategoryList();
            result.ForEach(x =>
            {
                cmbBoxAddCategoryUpperCategory.Items.Add(x.CategoryName);
            });
            pnlEkle.Visible = true;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            dataGridView1.DataSource = useCategoryDAL.GetAllCategoryDetailForAdmin();
            pnlListele.Visible = true;
            ChangeDatagridViewsColumnNames(dataGridView1);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            pnlAra.Visible = true;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            pnlGuncelle.Visible = true;
            var result = useCategoryDAL.GetCategoryList();
            result.ForEach(x =>
            {
                cmbBoxUpdateCategoryUpperCategory.Items.Add(x.CategoryName);
            });
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CloseAllPages();
            var result = useCategoryDAL.GetCategoryList();
            result.ForEach(x =>
            {
                cmbBoxDeleteCategoryUpperCategory.Items.Add(x.CategoryName);
            });
            pnlSil.Visible = true;
        }

        private void btnSearchCategorySearch_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = useCategoryDAL.GetCategoriesWithFilterForAdmin(txtSearchCategoryName.Text);
            ChangeDatagridViewsColumnNames(dataGridView2);
        }

        private void btnDeleteCategorySearch_Click(object sender, EventArgs e)
        {
            try
            {
                var result = useCategoryDAL.GetCategoryDetailsWithCategoryName(txtDeleteCategoryName.Text);
                if (result != null)
                {
                    cmbBoxDeleteCategoryUpperCategory.SelectedIndex = cmbBoxDeleteCategoryUpperCategory.FindString(useCategoryDAL.GetCategoryNameWithCategoryID(result.UstCategoryID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCategoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = useCategoryDAL.DeleteCategory(new CategoryDTO()
                {
                    CategoryName = txtDeleteCategoryName.Text,
                });
                if (result)
                {
                    MessageBox.Show("Kategori Silindi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtDeleteCategoryName.Text = "";
        }

        private void btnUpdateCategorySearch_Click(object sender, EventArgs e)
        {
            try
            {
                var result = useCategoryDAL.GetCategoryDetailsWithCategoryName(txtDeleteCategoryName.Text);
                if (result != null)
                {
                    cmbBoxUpdateCategoryUpperCategory.SelectedIndex = cmbBoxUpdateCategoryUpperCategory.FindString(useCategoryDAL.GetCategoryNameWithCategoryID(result.UstCategoryID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateCategoryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateCategoryDTO categoryDTO = new UpdateCategoryDTO()
                {
                    CategoryName = txtUpdateCategoryName.Text,
                    UstCategoryID = ((CategoryDTO)cmbBoxUpdateCategoryUpperCategory.SelectedItem).CategoryID,
                };
                bool result = useCategoryDAL.UpdateCategory(categoryDTO);
                if (result)
                {
                    MessageBox.Show("Kategori Güncellendi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCategoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = useCategoryDAL.AddCategory(new AddCategoryDTO()
                {
                    CategoryName = txtAddCategoryName.Text,
                    UstCategoryID = ((CategoryDTO)cmbBoxAddCategoryUpperCategory.SelectedItem).CategoryID,
                });
                
                if (result)
                {
                    MessageBox.Show("Kategori Eklendi.");
                }
            }
            catch(FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ChangeDatagridViewsColumnNames(DataGridView colname)
        {
            colname.Columns[0].HeaderText = "Kategori ID";
            colname.Columns[1].HeaderText = "Kategori Adı";
            colname.Columns[2].HeaderText = "Üst Kategori Adı";
            colname.Columns[3].HeaderText = "Aktif Mi?";
            colname.Columns[4].HeaderText = "Oluşturulma Tarihi";
            colname.Columns[5].HeaderText = "Oluşturan Kişi";
            colname.ForeColor = Color.Black;
            foreach (DataGridViewColumn col in colname.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
