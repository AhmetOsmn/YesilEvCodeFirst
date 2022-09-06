namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    partial class UrunIslemleri
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
            this.btnListele = new System.Windows.Forms.Button();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pnlListele = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlAra = new System.Windows.Forms.Panel();
            this.tbUrunAra = new System.Windows.Forms.TextBox();
            this.lblUrunAra = new System.Windows.Forms.Label();
            this.dgvSearchProduct = new System.Windows.Forms.DataGridView();
            this.btnUrunuAra = new System.Windows.Forms.Button();
            this.pnlApprove = new System.Windows.Forms.Panel();
            this.dgvApprove = new System.Windows.Forms.DataGridView();
            this.gbProduct.SuspendLayout();
            this.pnlListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProduct)).BeginInit();
            this.pnlApprove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprove)).BeginInit();
            this.SuspendLayout();
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
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.btnSil);
            this.gbProduct.Controls.Add(this.btnListele);
            this.gbProduct.Controls.Add(this.btnAra);
            this.gbProduct.Controls.Add(this.btnOnayla);
            this.gbProduct.Controls.Add(this.btnEkle);
            this.gbProduct.Controls.Add(this.btnGuncelle);
            this.gbProduct.Location = new System.Drawing.Point(12, 12);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(95, 426);
            this.gbProduct.TabIndex = 1;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Ürün İşlemleri";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(6, 312);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 43);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
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
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(6, 165);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(83, 43);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 214);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 43);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(6, 263);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 43);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // pnlListele
            // 
            this.pnlListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlListele.Controls.Add(this.dgvProducts);
            this.pnlListele.Location = new System.Drawing.Point(113, 22);
            this.pnlListele.Name = "pnlListele";
            this.pnlListele.Size = new System.Drawing.Size(1142, 416);
            this.pnlListele.TabIndex = 2;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(3, 20);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(1136, 393);
            this.dgvProducts.TabIndex = 0;
            // 
            // pnlAra
            // 
            this.pnlAra.Controls.Add(this.btnUrunuAra);
            this.pnlAra.Controls.Add(this.lblUrunAra);
            this.pnlAra.Controls.Add(this.tbUrunAra);
            this.pnlAra.Controls.Add(this.dgvSearchProduct);
            this.pnlAra.Location = new System.Drawing.Point(113, 22);
            this.pnlAra.Name = "pnlAra";
            this.pnlAra.Size = new System.Drawing.Size(1145, 416);
            this.pnlAra.TabIndex = 1;
            // 
            // tbUrunAra
            // 
            this.tbUrunAra.Location = new System.Drawing.Point(120, 17);
            this.tbUrunAra.Name = "tbUrunAra";
            this.tbUrunAra.Size = new System.Drawing.Size(187, 20);
            this.tbUrunAra.TabIndex = 0;
            // 
            // lblUrunAra
            // 
            this.lblUrunAra.AutoSize = true;
            this.lblUrunAra.Location = new System.Drawing.Point(32, 20);
            this.lblUrunAra.Name = "lblUrunAra";
            this.lblUrunAra.Size = new System.Drawing.Size(82, 13);
            this.lblUrunAra.TabIndex = 1;
            this.lblUrunAra.Text = "Urun Adı Giriniz:";
            // 
            // dgvSearchProduct
            // 
            this.dgvSearchProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchProduct.Location = new System.Drawing.Point(3, 46);
            this.dgvSearchProduct.Name = "dgvSearchProduct";
            this.dgvSearchProduct.Size = new System.Drawing.Size(1136, 367);
            this.dgvSearchProduct.TabIndex = 2;
            // 
            // btnUrunuAra
            // 
            this.btnUrunuAra.Location = new System.Drawing.Point(328, 17);
            this.btnUrunuAra.Name = "btnUrunuAra";
            this.btnUrunuAra.Size = new System.Drawing.Size(75, 20);
            this.btnUrunuAra.TabIndex = 3;
            this.btnUrunuAra.Text = "Ara";
            this.btnUrunuAra.UseVisualStyleBackColor = true;
            this.btnUrunuAra.Click += new System.EventHandler(this.btnUrunuAra_Click);
            // 
            // pnlApprove
            // 
            this.pnlApprove.Controls.Add(this.dgvApprove);
            this.pnlApprove.Location = new System.Drawing.Point(113, 22);
            this.pnlApprove.Name = "pnlApprove";
            this.pnlApprove.Size = new System.Drawing.Size(1145, 416);
            this.pnlApprove.TabIndex = 4;
            // 
            // dgvApprove
            // 
            this.dgvApprove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApprove.Location = new System.Drawing.Point(3, 20);
            this.dgvApprove.Name = "dgvApprove";
            this.dgvApprove.Size = new System.Drawing.Size(1139, 393);
            this.dgvApprove.TabIndex = 5;
            // 
            // UrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 450);
            this.Controls.Add(this.pnlApprove);
            this.Controls.Add(this.gbProduct);
            this.Controls.Add(this.pnlAra);
            this.Controls.Add(this.pnlListele);
            this.Name = "UrunIslemleri";
            this.Text = "UrunIslemleri";
            this.gbProduct.ResumeLayout(false);
            this.pnlListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlAra.ResumeLayout(false);
            this.pnlAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProduct)).EndInit();
            this.pnlApprove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel pnlListele;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlAra;
        private System.Windows.Forms.Label lblUrunAra;
        private System.Windows.Forms.TextBox tbUrunAra;
        private System.Windows.Forms.DataGridView dgvSearchProduct;
        private System.Windows.Forms.Button btnUrunuAra;
        private System.Windows.Forms.Panel pnlApprove;
        private System.Windows.Forms.DataGridView dgvApprove;
    }
}