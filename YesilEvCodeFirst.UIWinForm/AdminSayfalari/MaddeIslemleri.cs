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
            foreach (DataGridViewColumn col in colname.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void CloseAllPanels()
        {
            pnlSupplementList.Visible = false;
            pnlSearchSuppliers.Visible = false;
            //pnlAddSupplement.Visible = false;
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            //pnlAddSupplement.Visible = true;
            //pnlAddSupplement.BorderStyle = BorderStyle.Fixed3D;
            //try
            //{
            //bool result = useSupplementDAL.AddSupplement(new AddSupplementDTO
            //{
            //    SupplementName = txtSupplementName.Text,
            //    Risk = (Risk)(cmbRiskRatio.SelectedIndex),
            //});
            //if (result)
            //{
            //    MessageBox.Show("Ürün Eklendi");
            //    CloseAllPages();
            //    BarcodeDTO barcodeDTO = new BarcodeDTO() { Barcode = txtAddAndUpdateProductAddProductBarcodeNo.Text };
            //    int lastAddedProductID = useProductDAL.GetProductDetailWithBarcode(barcodeDTO).ProductID;
            //    GoProductDetails(lastAddedProductID);
            //    CleanAddAndUpdateProduct();

            //}
            //else
            //{
            //    MessageBox.Show("Ürün zaten mevcutta var");
            //}
            //}
            //catch (FormatException fex)
            //{
            //    MessageBox.Show(fex.Message);
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
