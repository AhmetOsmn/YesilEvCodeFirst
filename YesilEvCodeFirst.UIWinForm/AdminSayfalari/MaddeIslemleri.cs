using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.Supplier;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Supplement;

namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    public partial class MaddeIslemleri : Form
    {
        readonly UseSupplementDAL useSupplementDAL = new UseSupplementDAL();

        public MaddeIslemleri()
        {
            InitializeComponent();
            InitializeComboBox();
            CloseAllPanels();
            pnlSupplementList.Visible = true;
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlSupplementList.Visible = true;
            pnlSupplementList.BorderStyle = BorderStyle.Fixed3D;
            dgvSupplements.DataSource = null;
            dgvSupplements.DataSource = useSupplementDAL.GetSupplementsForAdmin();
            ChangeDatagridViewsColumnNames(dgvSupplements);
        }
        private void ChangeDatagridViewsColumnNames(DataGridView colname)
        {
            colname.Columns[0].HeaderText = "MaddeID";
            colname.Columns[1].HeaderText = "Madde Adı";
            colname.Columns[2].HeaderText = "Risk Seviyesi";
            colname.Columns[3].HeaderText = "Aktif mi?";
            colname.Columns[4].HeaderText = "Oluşturulma Tarihi";
            colname.Columns[5].HeaderText = "Oluşturan Kişi";
            colname.ForeColor = Color.Black;
            foreach (DataGridViewColumn col in colname.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void CloseAllPanels()
        {
            pnlSupplementList.Visible = false;
            pnlSearchSuppliers.Visible = false;
            pnlAddSupplement.Visible = false;
            pnlUpdateSupplements.Visible = false;
            pnlDeleteSupplement.Visible = false;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlSearchSuppliers.BorderStyle = BorderStyle.Fixed3D;
            pnlSearchSuppliers.Visible = true;
        }

        private void btnSearchSuppliers_Click(object sender, EventArgs e)
        {
            dgvSearchSuppliers.DataSource = null;
            dgvSearchSuppliers.DataSource = useSupplementDAL.GetPSupplementListWithSearchbarForAdmin(txtSearchSuppliers.Text);
            ChangeDatagridViewsColumnNames(dgvSearchSuppliers);
        }

        private void InitializeComboBox()
        {
            cmbAddRiskRatio.Items.AddRange(Enum.GetNames(typeof(Risk)));
            cmbUpdateRiskRatio.Items.AddRange(Enum.GetNames(typeof(Risk)));
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlAddSupplement.Visible = true;
            pnlAddSupplement.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Clear()
        {
            txtAddSupplementName.Text = "";
            cmbAddRiskRatio.Text = "";
            txtUpdateSupplementName.Text = "";
            cmbUpdateRiskRatio.Text = "";
            txtDeleteSupplementName.Text = "";
            cmbDeleteRiskRatio.Text = "";
        }
        private void btnAddSupplement_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = useSupplementDAL.AddSupplement(new AddSupplementDTO
                {
                    SupplementName = txtAddSupplementName.Text,
                    Risk = (Risk)(cmbAddRiskRatio.SelectedIndex),
                });

                if (result)
                {
                    MessageBox.Show("Madde Eklendi.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Madde zaten mevcutta var.");
                }
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlUpdateSupplements.Visible = true;
            pnlUpdateSupplements.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnUpdateSupplement_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = useSupplementDAL.UpdateSupplementListWithSupplementName(new AddSupplementDTO
                {
                    SupplementName = txtUpdateSupplementName.Text,
                    Risk = (Risk)(cmbUpdateRiskRatio.SelectedIndex),
                });
                if (result)
                {
                    MessageBox.Show("Madde Güncellendi.");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Madde zaten mevcutta var.");
                }
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

        private void btnGetSupplement_Click(object sender, EventArgs e)
        {
            AddSupplementDTO dto = new AddSupplementDTO { SupplementName = txtUpdateSupplementName.Text };
            try
            {
                var listdto = useSupplementDAL.GetProductDetailWithBarcode(dto);
                if (listdto != null)
                {
                    cmbUpdateRiskRatio.Text = listdto.Risk.ToString();
                }
                else
                {
                    MessageBox.Show("Aradığınız madde bulunamadı.");
                }
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlDeleteSupplement.Visible = true;
            pnlDeleteSupplement.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnDeleteSupplementName_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Emin misiniz?", "Madde Sil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AddSupplementDTO supplement = new AddSupplementDTO { SupplementName = txtDeleteSupplementName.Text };
                try
                {
                    useSupplementDAL.DeleteSupplement(supplement);
                    MessageBox.Show("Madde silindi!");
                    Clear();
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
        }

        private void btnDeletePageGetSupplementDetail_Click(object sender, EventArgs e)
        {
            AddSupplementDTO dto = new AddSupplementDTO { SupplementName = txtDeleteSupplementName.Text };
            try
            {
                var listdto = useSupplementDAL.GetProductDetailWithBarcode(dto);
                if (listdto != null)
                {
                    cmbDeleteRiskRatio.Text = listdto.Risk.ToString();
                }
                else
                {
                    MessageBox.Show("Aradığınız madde bulunamadı.");
                }
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
    }
}
