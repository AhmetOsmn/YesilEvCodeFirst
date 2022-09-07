using System;
using System.Windows.Forms;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs.Supplier;

namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    public partial class UreticiIslemleri : Form
    {
        readonly UseSupplierDAL useSupplierDAL = new UseSupplierDAL();

        public UreticiIslemleri()
        {
            InitializeComponent();
            CloseAllPanels();
            pnlUreticiListele.Visible = true;
        }

        #region Funcs

        private void CloseAllPanels()
        {
            pnlUreticiListele.Visible = false;
            pnlUreticiArama.Visible = false;
            pnlUreticiEkle.Visible = false;
            pnlUreticiGuncelle.Visible = false;
            pnlUreticiSilmeSayfasi.Visible = false;
        }

        #endregion

        #region Group Box

        private void btnListele_Click(object sender, System.EventArgs e)
        {
            CloseAllPanels();
            pnlUreticiListele.Visible = true;
            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = useSupplierDAL.GetSuppliersForAdmin();
            //ChangeDatagridViewsColumnNames(dgvProducts);
        }

        private void btnAra_Click(object sender, System.EventArgs e)
        {
            CloseAllPanels();
            pnlUreticiArama.Visible = true;
        }

        private void btnEkle_Click(object sender, System.EventArgs e)
        {
            CloseAllPanels();
            pnlUreticiEkle.Visible = true;
        }

        private void btnGuncelle_Click(object sender, System.EventArgs e)
        {
            CloseAllPanels();
            pnlUreticiGuncelle.Visible = true;
        }

        private void btnSil_Click(object sender, System.EventArgs e)
        {
            CloseAllPanels();
            pnlUreticiSilmeSayfasi.Visible = true;
        }

        #endregion

        #region Search

        private void btnUreticiyiAra_Click(object sender, System.EventArgs e)
        {
            dgvSearchSuppliers.DataSource = null;
            dgvSearchSuppliers.DataSource = useSupplierDAL.GetSupplierListWithSearchbarForAdmin(tbUreticiAra.Text);
            //ChangeDatagridViewsColumnNames(dgvSearchProduct);
        }








        #endregion

        #region Add

        private void btnAddSupplier_Click(object sender, System.EventArgs e)
        {
            try
            {
                var result = useSupplierDAL.AddSupplier(new AddSupplierDTO { SupplierName = tbSupplierName.Text });
                if (result)
                {
                    MessageBox.Show("Üretici Eklendi!");
                    tbSupplierName.Text = "";

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

        #endregion

        #region Update

        private void btnUretiyiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var result = useSupplierDAL.UpdateSupplier(new UpdateSupplierDTO { SupplierName = tbUreticiGuncelleEskiAd.Text, SupplierNewName = tbUreticiGuncelleYeniAd.Text });
                if (result)
                {
                    MessageBox.Show("Üretici Güncellendi!");
                    tbUreticiGuncelleEskiAd.Text = "";
                    tbUreticiGuncelleYeniAd.Text = "";
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


        #endregion

        // todo: uretici silinince, uretici ile iliskili urun icin bir sey yapilmali mi?

        private void btnUreticiyiSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Emin misiniz?", "Üretici Sil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var result = useSupplierDAL.DeleteSupplier(new AddSupplierDTO { SupplierName = tbSilinecekUreticiAdi.Text });
                    if (result)
                    {
                        MessageBox.Show("Üretici Silindi!");
                        tbSilinecekUreticiAdi.Text = "";
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
}