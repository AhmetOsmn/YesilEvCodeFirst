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
            this.pnlUpdateSupplements = new System.Windows.Forms.Panel();
            this.btnUpdateSupplement = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetSupplement = new System.Windows.Forms.Button();
            this.cmbUpdateRiskRatio = new System.Windows.Forms.ComboBox();
            this.txtUpdateSupplementName = new System.Windows.Forms.TextBox();
            this.lblUpdateSupplementName = new System.Windows.Forms.Label();
            this.lblUpdateRiskRatio = new System.Windows.Forms.Label();
            this.pnlAddSupplement = new System.Windows.Forms.Panel();
            this.btnAddSupplement = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAddRiskRatio = new System.Windows.Forms.ComboBox();
            this.txtAddSupplementName = new System.Windows.Forms.TextBox();
            this.lblAddSupplementName = new System.Windows.Forms.Label();
            this.lblAddRiskRatio = new System.Windows.Forms.Label();
            this.pnlSearchSuppliers = new System.Windows.Forms.Panel();
            this.btnSearchSuppliers = new System.Windows.Forms.Button();
            this.txtSearchSuppliers = new System.Windows.Forms.TextBox();
            this.lblSearchSuppliers = new System.Windows.Forms.Label();
            this.dgvSearchSuppliers = new System.Windows.Forms.DataGridView();
            this.pnlSupplementList = new System.Windows.Forms.Panel();
            this.dgvSupplements = new System.Windows.Forms.DataGridView();
            this.pnlDeleteSupplement = new System.Windows.Forms.Panel();
            this.gbSupplement = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnDeleteSupplementName = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeletePageGetSupplementDetail = new System.Windows.Forms.Button();
            this.cmbDeleteRiskRatio = new System.Windows.Forms.ComboBox();
            this.txtDeleteSupplementName = new System.Windows.Forms.TextBox();
            this.lblDeleteSupplementName = new System.Windows.Forms.Label();
            this.lblDeleteRiskRatio = new System.Windows.Forms.Label();
            this.pnlIslemler.SuspendLayout();
            this.pnlUpdateSupplements.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlAddSupplement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlSearchSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSuppliers)).BeginInit();
            this.pnlSupplementList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplements)).BeginInit();
            this.pnlDeleteSupplement.SuspendLayout();
            this.gbSupplement.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIslemler
            // 
            this.pnlIslemler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlIslemler.Controls.Add(this.pnlUpdateSupplements);
            this.pnlIslemler.Controls.Add(this.pnlAddSupplement);
            this.pnlIslemler.Controls.Add(this.pnlSearchSuppliers);
            this.pnlIslemler.Controls.Add(this.pnlSupplementList);
            this.pnlIslemler.Controls.Add(this.pnlDeleteSupplement);
            this.pnlIslemler.Location = new System.Drawing.Point(113, 22);
            this.pnlIslemler.Name = "pnlIslemler";
            this.pnlIslemler.Size = new System.Drawing.Size(759, 416);
            this.pnlIslemler.TabIndex = 4;
            // 
            // pnlUpdateSupplements
            // 
            this.pnlUpdateSupplements.Controls.Add(this.btnUpdateSupplement);
            this.pnlUpdateSupplements.Controls.Add(this.groupBox2);
            this.pnlUpdateSupplements.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdateSupplements.Name = "pnlUpdateSupplements";
            this.pnlUpdateSupplements.Size = new System.Drawing.Size(759, 417);
            this.pnlUpdateSupplements.TabIndex = 4;
            // 
            // btnUpdateSupplement
            // 
            this.btnUpdateSupplement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSupplement.Location = new System.Drawing.Point(529, 289);
            this.btnUpdateSupplement.Name = "btnUpdateSupplement";
            this.btnUpdateSupplement.Size = new System.Drawing.Size(128, 38);
            this.btnUpdateSupplement.TabIndex = 5;
            this.btnUpdateSupplement.Text = "Madde Güncelleme";
            this.btnUpdateSupplement.UseVisualStyleBackColor = true;
            this.btnUpdateSupplement.Click += new System.EventHandler(this.btnUpdateSupplement_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetSupplement);
            this.groupBox2.Controls.Add(this.cmbUpdateRiskRatio);
            this.groupBox2.Controls.Add(this.txtUpdateSupplementName);
            this.groupBox2.Controls.Add(this.lblUpdateSupplementName);
            this.groupBox2.Controls.Add(this.lblUpdateRiskRatio);
            this.groupBox2.Location = new System.Drawing.Point(143, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Madde Güncelleme";
            // 
            // btnGetSupplement
            // 
            this.btnGetSupplement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetSupplement.Location = new System.Drawing.Point(405, 65);
            this.btnGetSupplement.Name = "btnGetSupplement";
            this.btnGetSupplement.Size = new System.Drawing.Size(103, 22);
            this.btnGetSupplement.TabIndex = 6;
            this.btnGetSupplement.Text = "Madde Getir";
            this.btnGetSupplement.UseVisualStyleBackColor = true;
            this.btnGetSupplement.Click += new System.EventHandler(this.btnGetSupplement_Click);
            // 
            // cmbUpdateRiskRatio
            // 
            this.cmbUpdateRiskRatio.FormattingEnabled = true;
            this.cmbUpdateRiskRatio.Location = new System.Drawing.Point(195, 103);
            this.cmbUpdateRiskRatio.Name = "cmbUpdateRiskRatio";
            this.cmbUpdateRiskRatio.Size = new System.Drawing.Size(204, 21);
            this.cmbUpdateRiskRatio.TabIndex = 3;
            // 
            // txtUpdateSupplementName
            // 
            this.txtUpdateSupplementName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateSupplementName.Location = new System.Drawing.Point(195, 65);
            this.txtUpdateSupplementName.Name = "txtUpdateSupplementName";
            this.txtUpdateSupplementName.Size = new System.Drawing.Size(204, 22);
            this.txtUpdateSupplementName.TabIndex = 2;
            // 
            // lblUpdateSupplementName
            // 
            this.lblUpdateSupplementName.AutoSize = true;
            this.lblUpdateSupplementName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateSupplementName.Location = new System.Drawing.Point(45, 65);
            this.lblUpdateSupplementName.Name = "lblUpdateSupplementName";
            this.lblUpdateSupplementName.Size = new System.Drawing.Size(83, 19);
            this.lblUpdateSupplementName.TabIndex = 0;
            this.lblUpdateSupplementName.Text = "Madde Adı:";
            // 
            // lblUpdateRiskRatio
            // 
            this.lblUpdateRiskRatio.AutoSize = true;
            this.lblUpdateRiskRatio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateRiskRatio.Location = new System.Drawing.Point(45, 102);
            this.lblUpdateRiskRatio.Name = "lblUpdateRiskRatio";
            this.lblUpdateRiskRatio.Size = new System.Drawing.Size(96, 19);
            this.lblUpdateRiskRatio.TabIndex = 1;
            this.lblUpdateRiskRatio.Text = "Risk Seviyesi:";
            // 
            // pnlAddSupplement
            // 
            this.pnlAddSupplement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAddSupplement.Controls.Add(this.btnAddSupplement);
            this.pnlAddSupplement.Controls.Add(this.groupBox1);
            this.pnlAddSupplement.Location = new System.Drawing.Point(0, 0);
            this.pnlAddSupplement.Name = "pnlAddSupplement";
            this.pnlAddSupplement.Size = new System.Drawing.Size(759, 417);
            this.pnlAddSupplement.TabIndex = 5;
            // 
            // btnAddSupplement
            // 
            this.btnAddSupplement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplement.Location = new System.Drawing.Point(446, 274);
            this.btnAddSupplement.Name = "btnAddSupplement";
            this.btnAddSupplement.Size = new System.Drawing.Size(128, 38);
            this.btnAddSupplement.TabIndex = 3;
            this.btnAddSupplement.Text = "Madde Ekleme";
            this.btnAddSupplement.UseVisualStyleBackColor = true;
            this.btnAddSupplement.Click += new System.EventHandler(this.btnAddSupplement_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAddRiskRatio);
            this.groupBox1.Controls.Add(this.txtAddSupplementName);
            this.groupBox1.Controls.Add(this.lblAddSupplementName);
            this.groupBox1.Controls.Add(this.lblAddRiskRatio);
            this.groupBox1.Location = new System.Drawing.Point(101, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Madde Ekleme";
            // 
            // cmbAddRiskRatio
            // 
            this.cmbAddRiskRatio.FormattingEnabled = true;
            this.cmbAddRiskRatio.Location = new System.Drawing.Point(195, 103);
            this.cmbAddRiskRatio.Name = "cmbAddRiskRatio";
            this.cmbAddRiskRatio.Size = new System.Drawing.Size(204, 21);
            this.cmbAddRiskRatio.TabIndex = 3;
            // 
            // txtAddSupplementName
            // 
            this.txtAddSupplementName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddSupplementName.Location = new System.Drawing.Point(195, 29);
            this.txtAddSupplementName.Name = "txtAddSupplementName";
            this.txtAddSupplementName.Size = new System.Drawing.Size(204, 22);
            this.txtAddSupplementName.TabIndex = 2;
            // 
            // lblAddSupplementName
            // 
            this.lblAddSupplementName.AutoSize = true;
            this.lblAddSupplementName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddSupplementName.Location = new System.Drawing.Point(45, 29);
            this.lblAddSupplementName.Name = "lblAddSupplementName";
            this.lblAddSupplementName.Size = new System.Drawing.Size(83, 19);
            this.lblAddSupplementName.TabIndex = 0;
            this.lblAddSupplementName.Text = "Madde Adı:";
            // 
            // lblAddRiskRatio
            // 
            this.lblAddRiskRatio.AutoSize = true;
            this.lblAddRiskRatio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddRiskRatio.Location = new System.Drawing.Point(45, 102);
            this.lblAddRiskRatio.Name = "lblAddRiskRatio";
            this.lblAddRiskRatio.Size = new System.Drawing.Size(96, 19);
            this.lblAddRiskRatio.TabIndex = 1;
            this.lblAddRiskRatio.Text = "Risk Seviyesi:";
            // 
            // pnlSearchSuppliers
            // 
            this.pnlSearchSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearchSuppliers.Controls.Add(this.btnSearchSuppliers);
            this.pnlSearchSuppliers.Controls.Add(this.txtSearchSuppliers);
            this.pnlSearchSuppliers.Controls.Add(this.lblSearchSuppliers);
            this.pnlSearchSuppliers.Controls.Add(this.dgvSearchSuppliers);
            this.pnlSearchSuppliers.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchSuppliers.Name = "pnlSearchSuppliers";
            this.pnlSearchSuppliers.Size = new System.Drawing.Size(759, 417);
            this.pnlSearchSuppliers.TabIndex = 1;
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
            // txtSearchSuppliers
            // 
            this.txtSearchSuppliers.Location = new System.Drawing.Point(110, 13);
            this.txtSearchSuppliers.Name = "txtSearchSuppliers";
            this.txtSearchSuppliers.Size = new System.Drawing.Size(190, 20);
            this.txtSearchSuppliers.TabIndex = 3;
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
            // pnlSupplementList
            // 
            this.pnlSupplementList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSupplementList.Controls.Add(this.dgvSupplements);
            this.pnlSupplementList.ForeColor = System.Drawing.SystemColors.Control;
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
            this.dgvSupplements.Size = new System.Drawing.Size(759, 397);
            this.dgvSupplements.TabIndex = 0;
            // 
            // pnlDeleteSupplement
            // 
            this.pnlDeleteSupplement.Controls.Add(this.btnDeleteSupplementName);
            this.pnlDeleteSupplement.Controls.Add(this.groupBox3);
            this.pnlDeleteSupplement.Location = new System.Drawing.Point(0, 0);
            this.pnlDeleteSupplement.Name = "pnlDeleteSupplement";
            this.pnlDeleteSupplement.Size = new System.Drawing.Size(759, 417);
            this.pnlDeleteSupplement.TabIndex = 7;
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
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnDeleteSupplementName
            // 
            this.btnDeleteSupplementName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSupplementName.Location = new System.Drawing.Point(508, 289);
            this.btnDeleteSupplementName.Name = "btnDeleteSupplementName";
            this.btnDeleteSupplementName.Size = new System.Drawing.Size(128, 38);
            this.btnDeleteSupplementName.TabIndex = 7;
            this.btnDeleteSupplementName.Text = "Madde Silme";
            this.btnDeleteSupplementName.UseVisualStyleBackColor = true;
            this.btnDeleteSupplementName.Click += new System.EventHandler(this.btnDeleteSupplementName_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeletePageGetSupplementDetail);
            this.groupBox3.Controls.Add(this.cmbDeleteRiskRatio);
            this.groupBox3.Controls.Add(this.txtDeleteSupplementName);
            this.groupBox3.Controls.Add(this.lblDeleteSupplementName);
            this.groupBox3.Controls.Add(this.lblDeleteRiskRatio);
            this.groupBox3.Location = new System.Drawing.Point(122, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 193);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Madde Silme";
            // 
            // btnDeletePageGetSupplementDetail
            // 
            this.btnDeletePageGetSupplementDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePageGetSupplementDetail.Location = new System.Drawing.Point(405, 65);
            this.btnDeletePageGetSupplementDetail.Name = "btnDeletePageGetSupplementDetail";
            this.btnDeletePageGetSupplementDetail.Size = new System.Drawing.Size(103, 22);
            this.btnDeletePageGetSupplementDetail.TabIndex = 6;
            this.btnDeletePageGetSupplementDetail.Text = "Madde Getir";
            this.btnDeletePageGetSupplementDetail.UseVisualStyleBackColor = true;
            this.btnDeletePageGetSupplementDetail.Click += new System.EventHandler(this.btnDeletePageGetSupplementDetail_Click);
            // 
            // cmbDeleteRiskRatio
            // 
            this.cmbDeleteRiskRatio.FormattingEnabled = true;
            this.cmbDeleteRiskRatio.Location = new System.Drawing.Point(195, 103);
            this.cmbDeleteRiskRatio.Name = "cmbDeleteRiskRatio";
            this.cmbDeleteRiskRatio.Size = new System.Drawing.Size(204, 21);
            this.cmbDeleteRiskRatio.TabIndex = 3;
            // 
            // txtDeleteSupplementName
            // 
            this.txtDeleteSupplementName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDeleteSupplementName.Location = new System.Drawing.Point(195, 65);
            this.txtDeleteSupplementName.Name = "txtDeleteSupplementName";
            this.txtDeleteSupplementName.Size = new System.Drawing.Size(204, 22);
            this.txtDeleteSupplementName.TabIndex = 2;
            // 
            // lblDeleteSupplementName
            // 
            this.lblDeleteSupplementName.AutoSize = true;
            this.lblDeleteSupplementName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeleteSupplementName.Location = new System.Drawing.Point(45, 65);
            this.lblDeleteSupplementName.Name = "lblDeleteSupplementName";
            this.lblDeleteSupplementName.Size = new System.Drawing.Size(83, 19);
            this.lblDeleteSupplementName.TabIndex = 0;
            this.lblDeleteSupplementName.Text = "Madde Adı:";
            // 
            // lblDeleteRiskRatio
            // 
            this.lblDeleteRiskRatio.AutoSize = true;
            this.lblDeleteRiskRatio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeleteRiskRatio.Location = new System.Drawing.Point(45, 102);
            this.lblDeleteRiskRatio.Name = "lblDeleteRiskRatio";
            this.lblDeleteRiskRatio.Size = new System.Drawing.Size(96, 19);
            this.lblDeleteRiskRatio.TabIndex = 1;
            this.lblDeleteRiskRatio.Text = "Risk Seviyesi:";
            // 
            // MaddeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.pnlIslemler);
            this.Controls.Add(this.gbSupplement);
            this.Name = "MaddeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaddeIslemleri";
            this.pnlIslemler.ResumeLayout(false);
            this.pnlUpdateSupplements.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlAddSupplement.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlSearchSuppliers.ResumeLayout(false);
            this.pnlSearchSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSuppliers)).EndInit();
            this.pnlSupplementList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplements)).EndInit();
            this.pnlDeleteSupplement.ResumeLayout(false);
            this.gbSupplement.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Panel pnlAddSupplement;
        private System.Windows.Forms.Button btnSearchSuppliers;
        private System.Windows.Forms.TextBox txtSearchSuppliers;
        private System.Windows.Forms.Label lblSearchSuppliers;
        private System.Windows.Forms.DataGridView dgvSearchSuppliers;
        private System.Windows.Forms.Label lblAddSupplementName;
        private System.Windows.Forms.Label lblAddRiskRatio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddSupplementName;
        private System.Windows.Forms.ComboBox cmbAddRiskRatio;
        private System.Windows.Forms.Button btnAddSupplement;
        private System.Windows.Forms.Panel pnlUpdateSupplements;
        private System.Windows.Forms.Button btnUpdateSupplement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbUpdateRiskRatio;
        private System.Windows.Forms.TextBox txtUpdateSupplementName;
        private System.Windows.Forms.Label lblUpdateSupplementName;
        private System.Windows.Forms.Label lblUpdateRiskRatio;
        private System.Windows.Forms.Button btnGetSupplement;
        private System.Windows.Forms.Panel pnlDeleteSupplement;
        private System.Windows.Forms.Button btnDeleteSupplementName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeletePageGetSupplementDetail;
        private System.Windows.Forms.ComboBox cmbDeleteRiskRatio;
        private System.Windows.Forms.TextBox txtDeleteSupplementName;
        private System.Windows.Forms.Label lblDeleteSupplementName;
        private System.Windows.Forms.Label lblDeleteRiskRatio;
    }
}