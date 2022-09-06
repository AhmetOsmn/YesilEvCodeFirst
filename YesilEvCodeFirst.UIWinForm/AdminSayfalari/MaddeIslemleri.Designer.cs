namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    partial class MaddeIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlIslemler = new System.Windows.Forms.Panel();
            this.pnlSupplementList = new System.Windows.Forms.Panel();
            this.dgvSupplements = new System.Windows.Forms.DataGridView();
            this.gbSupplement = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pnlSearchSuppliers = new System.Windows.Forms.Panel();
            this.lblSearchSuppliers = new System.Windows.Forms.Label();
            this.dgvSearchSuppliers = new System.Windows.Forms.DataGridView();
            this.txtSearchSuppliers = new System.Windows.Forms.TextBox();
            this.btnSearchSuppliers = new System.Windows.Forms.Button();
            this.pnlIslemler.SuspendLayout();
            this.pnlSupplementList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplements)).BeginInit();
            this.gbSupplement.SuspendLayout();
            this.pnlSearchSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIslemler
            // 
            this.pnlIslemler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlIslemler.Controls.Add(this.pnlSupplementList);
            this.pnlIslemler.Location = new System.Drawing.Point(113, 22);
            this.pnlIslemler.Name = "pnlIslemler";
            this.pnlIslemler.Size = new System.Drawing.Size(759, 416);
            this.pnlIslemler.TabIndex = 4;
            // 
            // pnlSupplementList
            // 
            this.pnlSupplementList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSupplementList.Controls.Add(this.dgvSupplements);
            this.pnlSupplementList.Location = new System.Drawing.Point(0, 0);
            this.pnlSupplementList.Name = "pnlSupplementList";
            this.pnlSupplementList.Size = new System.Drawing.Size(759, 416);
            this.pnlSupplementList.TabIndex = 0;
            // 
            // dgvSupplements
            // 
            this.dgvSupplements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplements.Location = new System.Drawing.Point(-2, -3);
            this.dgvSupplements.Name = "dgvSupplements";
            this.dgvSupplements.Size = new System.Drawing.Size(759, 417);
            this.dgvSupplements.TabIndex = 0;
            // 
            // gbSupplement
            // 
            this.gbSupplement.Controls.Add(this.btnSil);
            this.gbSupplement.Controls.Add(this.btnListele);
            this.gbSupplement.Controls.Add(this.btnAra);
            this.gbSupplement.Controls.Add(this.btnEkle);
            this.gbSupplement.Controls.Add(this.btnGuncelle);
            this.gbSupplement.Location = new System.Drawing.Point(12, 12);
            this.gbSupplement.Name = "gbSupplement";
            this.gbSupplement.Size = new System.Drawing.Size(95, 426);
            this.gbSupplement.TabIndex = 3;
            this.gbSupplement.TabStop = false;
            this.gbSupplement.Text = "Madde İşlemleri";
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Location = new System.Drawing.Point(6, 263);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 43);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListele.Location = new System.Drawing.Point(6, 67);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(83, 43);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnAra
            // 
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.Location = new System.Drawing.Point(6, 116);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(83, 43);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Location = new System.Drawing.Point(6, 165);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 43);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Location = new System.Drawing.Point(6, 214);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 43);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // pnlSearchSuppliers
            // 
            this.pnlSearchSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearchSuppliers.Controls.Add(this.btnSearchSuppliers);
            this.pnlSearchSuppliers.Controls.Add(this.txtSearchSuppliers);
            this.pnlSearchSuppliers.Controls.Add(this.lblSearchSuppliers);
            this.pnlSearchSuppliers.Controls.Add(this.dgvSearchSuppliers);
            this.pnlSearchSuppliers.Location = new System.Drawing.Point(113, 21);
            this.pnlSearchSuppliers.Name = "pnlSearchSuppliers";
            this.pnlSearchSuppliers.Size = new System.Drawing.Size(759, 417);
            this.pnlSearchSuppliers.TabIndex = 1;
            // 
            // lblSearchSuppliers
            // 
            this.lblSearchSuppliers.AutoSize = true;
            this.lblSearchSuppliers.Location = new System.Drawing.Point(3, 16);
            this.lblSearchSuppliers.Name = "lblSearchSuppliers";
            this.lblSearchSuppliers.Size = new System.Drawing.Size(92, 13);
            this.lblSearchSuppliers.TabIndex = 2;
            this.lblSearchSuppliers.Text = "Madde Adı Giriniz:";
            // 
            // dgvSearchSuppliers
            // 
            this.dgvSearchSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchSuppliers.Location = new System.Drawing.Point(-2, 32);
            this.dgvSearchSuppliers.Name = "dgvSearchSuppliers";
            this.dgvSearchSuppliers.Size = new System.Drawing.Size(759, 383);
            this.dgvSearchSuppliers.TabIndex = 0;
            // 
            // txtSearchSuppliers
            // 
            this.txtSearchSuppliers.Location = new System.Drawing.Point(110, 13);
            this.txtSearchSuppliers.Name = "txtSearchSuppliers";
            this.txtSearchSuppliers.Size = new System.Drawing.Size(190, 20);
            this.txtSearchSuppliers.TabIndex = 3;
            // 
            // btnSearchSuppliers
            // 
            this.btnSearchSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchSuppliers.Location = new System.Drawing.Point(306, 12);
            this.btnSearchSuppliers.Name = "btnSearchSuppliers";
            this.btnSearchSuppliers.Size = new System.Drawing.Size(64, 20);
            this.btnSearchSuppliers.TabIndex = 4;
            this.btnSearchSuppliers.Text = "Ara";
            this.btnSearchSuppliers.UseVisualStyleBackColor = true;
            this.btnSearchSuppliers.Click += new System.EventHandler(this.btnSearchSuppliers_Click);
            // 
            // MaddeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.pnlIslemler);
            this.Controls.Add(this.gbSupplement);
            this.Controls.Add(this.pnlSearchSuppliers);
            this.Name = "MaddeIslemleri";
            this.Text = "MaddeIslemleri";
            this.pnlIslemler.ResumeLayout(false);
            this.pnlSupplementList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplements)).EndInit();
            this.gbSupplement.ResumeLayout(false);
            this.pnlSearchSuppliers.ResumeLayout(false);
            this.pnlSearchSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIslemler;
        private System.Windows.Forms.GroupBox gbSupplement;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel pnlSupplementList;
        private System.Windows.Forms.DataGridView dgvSupplements;
        private System.Windows.Forms.Panel pnlSearchSuppliers;
        private System.Windows.Forms.DataGridView dgvSearchSuppliers;
        private System.Windows.Forms.Label lblSearchSuppliers;
        private System.Windows.Forms.TextBox txtSearchSuppliers;
        private System.Windows.Forms.Button btnSearchSuppliers;
    }
}