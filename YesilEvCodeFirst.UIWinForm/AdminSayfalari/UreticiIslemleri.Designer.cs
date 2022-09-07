namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    partial class UreticiIslemleri
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
            this.pnlUreticiListele = new System.Windows.Forms.Panel();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.lblUreticiListelemeSayfasi = new System.Windows.Forms.Label();
            this.gbSupplement = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pnlUreticiArama = new System.Windows.Forms.Panel();
            this.btnUreticiyiAra = new System.Windows.Forms.Button();
            this.lblUrunAra = new System.Windows.Forms.Label();
            this.tbUreticiAra = new System.Windows.Forms.TextBox();
            this.dgvSearchSuppliers = new System.Windows.Forms.DataGridView();
            this.lblUreticiAramaSayfasi = new System.Windows.Forms.Label();
            this.pnlUreticiEkle = new System.Windows.Forms.Panel();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.lblUreticiAdi = new System.Windows.Forms.Label();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.lblUreticiEkle = new System.Windows.Forms.Label();
            this.pnlUreticiGuncelle = new System.Windows.Forms.Panel();
            this.lblUreticiGuncellemeSayfasi = new System.Windows.Forms.Label();
            this.pnlUreticiSilmeSayfasi = new System.Windows.Forms.Panel();
            this.lblUreticiSilmeSayfasi = new System.Windows.Forms.Label();
            this.lblUreticiGuncelleEskiAd = new System.Windows.Forms.Label();
            this.lblUreticiGuncelleYeniAd = new System.Windows.Forms.Label();
            this.tbUreticiGuncelleEskiAd = new System.Windows.Forms.TextBox();
            this.tbUreticiGuncelleYeniAd = new System.Windows.Forms.TextBox();
            this.btnUretiyiGuncelle = new System.Windows.Forms.Button();
            this.lblSilinecekUreticiAdi = new System.Windows.Forms.Label();
            this.tbSilinecekUreticiAdi = new System.Windows.Forms.TextBox();
            this.btnUreticiyiSil = new System.Windows.Forms.Button();
            this.pnlUreticiListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.gbSupplement.SuspendLayout();
            this.pnlUreticiArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSuppliers)).BeginInit();
            this.pnlUreticiEkle.SuspendLayout();
            this.pnlUreticiGuncelle.SuspendLayout();
            this.pnlUreticiSilmeSayfasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUreticiListele
            // 
            this.pnlUreticiListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlUreticiListele.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUreticiListele.Controls.Add(this.dgvSuppliers);
            this.pnlUreticiListele.Controls.Add(this.lblUreticiListelemeSayfasi);
            this.pnlUreticiListele.Location = new System.Drawing.Point(113, 12);
            this.pnlUreticiListele.Name = "pnlUreticiListele";
            this.pnlUreticiListele.Size = new System.Drawing.Size(1140, 423);
            this.pnlUreticiListele.TabIndex = 6;
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(3, 31);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.Size = new System.Drawing.Size(1130, 385);
            this.dgvSuppliers.TabIndex = 1;
            // 
            // lblUreticiListelemeSayfasi
            // 
            this.lblUreticiListelemeSayfasi.AutoSize = true;
            this.lblUreticiListelemeSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUreticiListelemeSayfasi.Location = new System.Drawing.Point(12, 15);
            this.lblUreticiListelemeSayfasi.Name = "lblUreticiListelemeSayfasi";
            this.lblUreticiListelemeSayfasi.Size = new System.Drawing.Size(146, 13);
            this.lblUreticiListelemeSayfasi.TabIndex = 0;
            this.lblUreticiListelemeSayfasi.Text = "Üretici Listeleme Sayfası";
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
            this.gbSupplement.TabIndex = 5;
            this.gbSupplement.TabStop = false;
            this.gbSupplement.Text = "Üretici İşlemleri";
            // 
            // btnSil
            // 
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
            this.btnGuncelle.Location = new System.Drawing.Point(6, 214);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 43);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pnlUreticiArama
            // 
            this.pnlUreticiArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlUreticiArama.Controls.Add(this.btnUreticiyiAra);
            this.pnlUreticiArama.Controls.Add(this.lblUrunAra);
            this.pnlUreticiArama.Controls.Add(this.tbUreticiAra);
            this.pnlUreticiArama.Controls.Add(this.dgvSearchSuppliers);
            this.pnlUreticiArama.Controls.Add(this.lblUreticiAramaSayfasi);
            this.pnlUreticiArama.Location = new System.Drawing.Point(113, 12);
            this.pnlUreticiArama.Name = "pnlUreticiArama";
            this.pnlUreticiArama.Size = new System.Drawing.Size(1140, 423);
            this.pnlUreticiArama.TabIndex = 7;
            // 
            // btnUreticiyiAra
            // 
            this.btnUreticiyiAra.Location = new System.Drawing.Point(475, 5);
            this.btnUreticiyiAra.Name = "btnUreticiyiAra";
            this.btnUreticiyiAra.Size = new System.Drawing.Size(75, 20);
            this.btnUreticiyiAra.TabIndex = 6;
            this.btnUreticiyiAra.Text = "Ara";
            this.btnUreticiyiAra.UseVisualStyleBackColor = true;
            this.btnUreticiyiAra.Click += new System.EventHandler(this.btnUreticiyiAra_Click);
            // 
            // lblUrunAra
            // 
            this.lblUrunAra.AutoSize = true;
            this.lblUrunAra.Location = new System.Drawing.Point(172, 8);
            this.lblUrunAra.Name = "lblUrunAra";
            this.lblUrunAra.Size = new System.Drawing.Size(89, 13);
            this.lblUrunAra.TabIndex = 5;
            this.lblUrunAra.Text = "Üretici Adı Giriniz:";
            // 
            // tbUreticiAra
            // 
            this.tbUreticiAra.Location = new System.Drawing.Point(267, 5);
            this.tbUreticiAra.Name = "tbUreticiAra";
            this.tbUreticiAra.Size = new System.Drawing.Size(187, 20);
            this.tbUreticiAra.TabIndex = 4;
            // 
            // dgvSearchSuppliers
            // 
            this.dgvSearchSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchSuppliers.Location = new System.Drawing.Point(3, 31);
            this.dgvSearchSuppliers.Name = "dgvSearchSuppliers";
            this.dgvSearchSuppliers.ReadOnly = true;
            this.dgvSearchSuppliers.Size = new System.Drawing.Size(1130, 385);
            this.dgvSearchSuppliers.TabIndex = 1;
            // 
            // lblUreticiAramaSayfasi
            // 
            this.lblUreticiAramaSayfasi.AutoSize = true;
            this.lblUreticiAramaSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUreticiAramaSayfasi.Location = new System.Drawing.Point(3, 8);
            this.lblUreticiAramaSayfasi.Name = "lblUreticiAramaSayfasi";
            this.lblUreticiAramaSayfasi.Size = new System.Drawing.Size(128, 13);
            this.lblUreticiAramaSayfasi.TabIndex = 0;
            this.lblUreticiAramaSayfasi.Text = "Üretici Arama Sayfası";
            // 
            // pnlUreticiEkle
            // 
            this.pnlUreticiEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlUreticiEkle.Controls.Add(this.btnAddSupplier);
            this.pnlUreticiEkle.Controls.Add(this.lblUreticiAdi);
            this.pnlUreticiEkle.Controls.Add(this.tbSupplierName);
            this.pnlUreticiEkle.Controls.Add(this.lblUreticiEkle);
            this.pnlUreticiEkle.Location = new System.Drawing.Point(113, 12);
            this.pnlUreticiEkle.Name = "pnlUreticiEkle";
            this.pnlUreticiEkle.Size = new System.Drawing.Size(1140, 423);
            this.pnlUreticiEkle.TabIndex = 8;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(313, 203);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(196, 33);
            this.btnAddSupplier.TabIndex = 3;
            this.btnAddSupplier.Text = "Kaydet";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // lblUreticiAdi
            // 
            this.lblUreticiAdi.AutoSize = true;
            this.lblUreticiAdi.Location = new System.Drawing.Point(249, 180);
            this.lblUreticiAdi.Name = "lblUreticiAdi";
            this.lblUreticiAdi.Size = new System.Drawing.Size(58, 13);
            this.lblUreticiAdi.TabIndex = 2;
            this.lblUreticiAdi.Text = "Üretici Adı:";
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Location = new System.Drawing.Point(313, 177);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.Size = new System.Drawing.Size(196, 20);
            this.tbSupplierName.TabIndex = 1;
            // 
            // lblUreticiEkle
            // 
            this.lblUreticiEkle.AutoSize = true;
            this.lblUreticiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUreticiEkle.Location = new System.Drawing.Point(3, 8);
            this.lblUreticiEkle.Name = "lblUreticiEkle";
            this.lblUreticiEkle.Size = new System.Drawing.Size(134, 13);
            this.lblUreticiEkle.TabIndex = 0;
            this.lblUreticiEkle.Text = "Üretici Ekleme Sayfası";
            // 
            // pnlUreticiGuncelle
            // 
            this.pnlUreticiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlUreticiGuncelle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUreticiGuncelle.Controls.Add(this.btnUretiyiGuncelle);
            this.pnlUreticiGuncelle.Controls.Add(this.tbUreticiGuncelleYeniAd);
            this.pnlUreticiGuncelle.Controls.Add(this.tbUreticiGuncelleEskiAd);
            this.pnlUreticiGuncelle.Controls.Add(this.lblUreticiGuncelleYeniAd);
            this.pnlUreticiGuncelle.Controls.Add(this.lblUreticiGuncelleEskiAd);
            this.pnlUreticiGuncelle.Controls.Add(this.lblUreticiGuncellemeSayfasi);
            this.pnlUreticiGuncelle.Location = new System.Drawing.Point(113, 12);
            this.pnlUreticiGuncelle.Name = "pnlUreticiGuncelle";
            this.pnlUreticiGuncelle.Size = new System.Drawing.Size(1140, 423);
            this.pnlUreticiGuncelle.TabIndex = 9;
            // 
            // lblUreticiGuncellemeSayfasi
            // 
            this.lblUreticiGuncellemeSayfasi.AutoSize = true;
            this.lblUreticiGuncellemeSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUreticiGuncellemeSayfasi.Location = new System.Drawing.Point(3, 8);
            this.lblUreticiGuncellemeSayfasi.Name = "lblUreticiGuncellemeSayfasi";
            this.lblUreticiGuncellemeSayfasi.Size = new System.Drawing.Size(159, 13);
            this.lblUreticiGuncellemeSayfasi.TabIndex = 0;
            this.lblUreticiGuncellemeSayfasi.Text = "Üretici Güncelleme Sayfası";
            // 
            // pnlUreticiSilmeSayfasi
            // 
            this.pnlUreticiSilmeSayfasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlUreticiSilmeSayfasi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUreticiSilmeSayfasi.Controls.Add(this.btnUreticiyiSil);
            this.pnlUreticiSilmeSayfasi.Controls.Add(this.tbSilinecekUreticiAdi);
            this.pnlUreticiSilmeSayfasi.Controls.Add(this.lblSilinecekUreticiAdi);
            this.pnlUreticiSilmeSayfasi.Controls.Add(this.lblUreticiSilmeSayfasi);
            this.pnlUreticiSilmeSayfasi.Location = new System.Drawing.Point(113, 12);
            this.pnlUreticiSilmeSayfasi.Name = "pnlUreticiSilmeSayfasi";
            this.pnlUreticiSilmeSayfasi.Size = new System.Drawing.Size(1140, 423);
            this.pnlUreticiSilmeSayfasi.TabIndex = 10;
            // 
            // lblUreticiSilmeSayfasi
            // 
            this.lblUreticiSilmeSayfasi.AutoSize = true;
            this.lblUreticiSilmeSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUreticiSilmeSayfasi.Location = new System.Drawing.Point(3, 8);
            this.lblUreticiSilmeSayfasi.Name = "lblUreticiSilmeSayfasi";
            this.lblUreticiSilmeSayfasi.Size = new System.Drawing.Size(123, 13);
            this.lblUreticiSilmeSayfasi.TabIndex = 0;
            this.lblUreticiSilmeSayfasi.Text = "Üretici Silme Sayfası";
            // 
            // lblUreticiGuncelleEskiAd
            // 
            this.lblUreticiGuncelleEskiAd.AutoSize = true;
            this.lblUreticiGuncelleEskiAd.Location = new System.Drawing.Point(262, 129);
            this.lblUreticiGuncelleEskiAd.Name = "lblUreticiGuncelleEskiAd";
            this.lblUreticiGuncelleEskiAd.Size = new System.Drawing.Size(95, 13);
            this.lblUreticiGuncelleEskiAd.TabIndex = 1;
            this.lblUreticiGuncelleEskiAd.Text = "Üreticinin Eski Adı:";
            // 
            // lblUreticiGuncelleYeniAd
            // 
            this.lblUreticiGuncelleYeniAd.AutoSize = true;
            this.lblUreticiGuncelleYeniAd.Location = new System.Drawing.Point(262, 178);
            this.lblUreticiGuncelleYeniAd.Name = "lblUreticiGuncelleYeniAd";
            this.lblUreticiGuncelleYeniAd.Size = new System.Drawing.Size(96, 13);
            this.lblUreticiGuncelleYeniAd.TabIndex = 2;
            this.lblUreticiGuncelleYeniAd.Text = "Üreticinin Yeni Adı:";
            // 
            // tbUreticiGuncelleEskiAd
            // 
            this.tbUreticiGuncelleEskiAd.Location = new System.Drawing.Point(365, 126);
            this.tbUreticiGuncelleEskiAd.Name = "tbUreticiGuncelleEskiAd";
            this.tbUreticiGuncelleEskiAd.Size = new System.Drawing.Size(183, 20);
            this.tbUreticiGuncelleEskiAd.TabIndex = 3;
            // 
            // tbUreticiGuncelleYeniAd
            // 
            this.tbUreticiGuncelleYeniAd.Location = new System.Drawing.Point(365, 175);
            this.tbUreticiGuncelleYeniAd.Name = "tbUreticiGuncelleYeniAd";
            this.tbUreticiGuncelleYeniAd.Size = new System.Drawing.Size(183, 20);
            this.tbUreticiGuncelleYeniAd.TabIndex = 4;
            // 
            // btnUretiyiGuncelle
            // 
            this.btnUretiyiGuncelle.Location = new System.Drawing.Point(365, 222);
            this.btnUretiyiGuncelle.Name = "btnUretiyiGuncelle";
            this.btnUretiyiGuncelle.Size = new System.Drawing.Size(183, 33);
            this.btnUretiyiGuncelle.TabIndex = 5;
            this.btnUretiyiGuncelle.Text = "Güncelle";
            this.btnUretiyiGuncelle.UseVisualStyleBackColor = true;
            this.btnUretiyiGuncelle.Click += new System.EventHandler(this.btnUretiyiGuncelle_Click);
            // 
            // lblSilinecekUreticiAdi
            // 
            this.lblSilinecekUreticiAdi.AutoSize = true;
            this.lblSilinecekUreticiAdi.Location = new System.Drawing.Point(247, 114);
            this.lblSilinecekUreticiAdi.Name = "lblSilinecekUreticiAdi";
            this.lblSilinecekUreticiAdi.Size = new System.Drawing.Size(104, 13);
            this.lblSilinecekUreticiAdi.TabIndex = 1;
            this.lblSilinecekUreticiAdi.Text = "Silinecek Üretici Adı:";
            // 
            // tbSilinecekUreticiAdi
            // 
            this.tbSilinecekUreticiAdi.Location = new System.Drawing.Point(357, 111);
            this.tbSilinecekUreticiAdi.Name = "tbSilinecekUreticiAdi";
            this.tbSilinecekUreticiAdi.Size = new System.Drawing.Size(191, 20);
            this.tbSilinecekUreticiAdi.TabIndex = 2;
            // 
            // btnUreticiyiSil
            // 
            this.btnUreticiyiSil.Location = new System.Drawing.Point(357, 152);
            this.btnUreticiyiSil.Name = "btnUreticiyiSil";
            this.btnUreticiyiSil.Size = new System.Drawing.Size(191, 39);
            this.btnUreticiyiSil.TabIndex = 3;
            this.btnUreticiyiSil.Text = "Sil";
            this.btnUreticiyiSil.UseVisualStyleBackColor = true;
            this.btnUreticiyiSil.Click += new System.EventHandler(this.btnUreticiyiSil_Click);
            // 
            // UreticiIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 450);
            this.Controls.Add(this.gbSupplement);
            this.Controls.Add(this.pnlUreticiSilmeSayfasi);
            this.Controls.Add(this.pnlUreticiGuncelle);
            this.Controls.Add(this.pnlUreticiEkle);
            this.Controls.Add(this.pnlUreticiArama);
            this.Controls.Add(this.pnlUreticiListele);
            this.Name = "UreticiIslemleri";
            this.Text = "UreticiIslemleri";
            this.pnlUreticiListele.ResumeLayout(false);
            this.pnlUreticiListele.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.gbSupplement.ResumeLayout(false);
            this.pnlUreticiArama.ResumeLayout(false);
            this.pnlUreticiArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSuppliers)).EndInit();
            this.pnlUreticiEkle.ResumeLayout(false);
            this.pnlUreticiEkle.PerformLayout();
            this.pnlUreticiGuncelle.ResumeLayout(false);
            this.pnlUreticiGuncelle.PerformLayout();
            this.pnlUreticiSilmeSayfasi.ResumeLayout(false);
            this.pnlUreticiSilmeSayfasi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUreticiListele;
        private System.Windows.Forms.GroupBox gbSupplement;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Label lblUreticiListelemeSayfasi;
        private System.Windows.Forms.Panel pnlUreticiArama;
        private System.Windows.Forms.DataGridView dgvSearchSuppliers;
        private System.Windows.Forms.Label lblUreticiAramaSayfasi;
        private System.Windows.Forms.Button btnUreticiyiAra;
        private System.Windows.Forms.Label lblUrunAra;
        private System.Windows.Forms.TextBox tbUreticiAra;
        private System.Windows.Forms.Panel pnlUreticiEkle;
        private System.Windows.Forms.Label lblUreticiEkle;
        private System.Windows.Forms.Panel pnlUreticiGuncelle;
        private System.Windows.Forms.Label lblUreticiGuncellemeSayfasi;
        private System.Windows.Forms.Panel pnlUreticiSilmeSayfasi;
        private System.Windows.Forms.Label lblUreticiSilmeSayfasi;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.Label lblUreticiAdi;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label lblUreticiGuncelleYeniAd;
        private System.Windows.Forms.Label lblUreticiGuncelleEskiAd;
        private System.Windows.Forms.TextBox tbUreticiGuncelleYeniAd;
        private System.Windows.Forms.TextBox tbUreticiGuncelleEskiAd;
        private System.Windows.Forms.Button btnUretiyiGuncelle;
        private System.Windows.Forms.Label lblSilinecekUreticiAdi;
        private System.Windows.Forms.TextBox tbSilinecekUreticiAdi;
        private System.Windows.Forms.Button btnUreticiyiSil;
    }
}