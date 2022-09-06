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
            this.gbSupplement = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.gbSupplement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIslemler
            // 
            this.pnlIslemler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlIslemler.Location = new System.Drawing.Point(113, 22);
            this.pnlIslemler.Name = "pnlIslemler";
            this.pnlIslemler.Size = new System.Drawing.Size(759, 416);
            this.pnlIslemler.TabIndex = 4;
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
            this.btnSil.Location = new System.Drawing.Point(6, 263);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 43);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(6, 67);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(83, 43);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(6, 116);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(83, 43);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 165);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 43);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(6, 214);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 43);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // MaddeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.pnlIslemler);
            this.Controls.Add(this.gbSupplement);
            this.Name = "MaddeIslemleri";
            this.Text = "MaddeIslemleri";
            this.gbSupplement.ResumeLayout(false);
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
    }
}