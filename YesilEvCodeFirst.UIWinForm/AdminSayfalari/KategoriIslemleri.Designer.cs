namespace YesilEvCodeFirst.UIWinForm.AdminSayfalari
{
    partial class KategoriIslemleri
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
            this.gbSupplement = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pnlListele = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlAra = new System.Windows.Forms.Panel();
            this.btnSearchCategorySearch = new System.Windows.Forms.Button();
            this.txtSearchCategoryName = new System.Windows.Forms.TextBox();
            this.lblSearchCategoryName = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnlEkle = new System.Windows.Forms.Panel();
            this.cmbBoxAddCategoryUpperCategory = new System.Windows.Forms.ComboBox();
            this.btnAddCategoryAdd = new System.Windows.Forms.Button();
            this.txtAddCategoryName = new System.Windows.Forms.TextBox();
            this.lblAddCategoryName = new System.Windows.Forms.Label();
            this.lblAddCategoryUpperCategory = new System.Windows.Forms.Label();
            this.pnlGuncelle = new System.Windows.Forms.Panel();
            this.cmbBoxUpdateCategoryUpperCategory = new System.Windows.Forms.ComboBox();
            this.btnUpdateCategoryUpdate = new System.Windows.Forms.Button();
            this.txtUpdateCategoryName = new System.Windows.Forms.TextBox();
            this.lblUpdateCategoryName = new System.Windows.Forms.Label();
            this.btnUpdateCategorySearch = new System.Windows.Forms.Button();
            this.lblUpdateCategoryEmail = new System.Windows.Forms.Label();
            this.pnlSil = new System.Windows.Forms.Panel();
            this.cmbBoxDeleteCategoryUpperCategory = new System.Windows.Forms.ComboBox();
            this.btnDeleteCategoryDelete = new System.Windows.Forms.Button();
            this.lblDeleteCategoryUpperCategory = new System.Windows.Forms.Label();
            this.btnDeleteCategorySearch = new System.Windows.Forms.Button();
            this.txtDeleteCategoryName = new System.Windows.Forms.TextBox();
            this.lblDeleteCategoryName = new System.Windows.Forms.Label();
            this.gbSupplement.SuspendLayout();
            this.pnlListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnlEkle.SuspendLayout();
            this.pnlGuncelle.SuspendLayout();
            this.pnlSil.SuspendLayout();
            this.SuspendLayout();
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
            this.gbSupplement.Text = "Kategori İşlemleri";
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
            // pnlListele
            // 
            this.pnlListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlListele.Controls.Add(this.dataGridView1);
            this.pnlListele.Location = new System.Drawing.Point(112, 20);
            this.pnlListele.Name = "pnlListele";
            this.pnlListele.Size = new System.Drawing.Size(1159, 416);
            this.pnlListele.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlAra
            // 
            this.pnlAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAra.Controls.Add(this.btnSearchCategorySearch);
            this.pnlAra.Controls.Add(this.txtSearchCategoryName);
            this.pnlAra.Controls.Add(this.lblSearchCategoryName);
            this.pnlAra.Controls.Add(this.dataGridView2);
            this.pnlAra.Location = new System.Drawing.Point(112, 20);
            this.pnlAra.Name = "pnlAra";
            this.pnlAra.Size = new System.Drawing.Size(1159, 416);
            this.pnlAra.TabIndex = 7;
            // 
            // btnSearchCategorySearch
            // 
            this.btnSearchCategorySearch.Location = new System.Drawing.Point(262, 10);
            this.btnSearchCategorySearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchCategorySearch.Name = "btnSearchCategorySearch";
            this.btnSearchCategorySearch.Size = new System.Drawing.Size(56, 19);
            this.btnSearchCategorySearch.TabIndex = 2;
            this.btnSearchCategorySearch.Text = "Ara";
            this.btnSearchCategorySearch.UseVisualStyleBackColor = true;
            this.btnSearchCategorySearch.Click += new System.EventHandler(this.btnSearchCategorySearch_Click);
            // 
            // txtSearchCategoryName
            // 
            this.txtSearchCategoryName.Location = new System.Drawing.Point(80, 11);
            this.txtSearchCategoryName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchCategoryName.Name = "txtSearchCategoryName";
            this.txtSearchCategoryName.Size = new System.Drawing.Size(170, 20);
            this.txtSearchCategoryName.TabIndex = 1;
            // 
            // lblSearchCategoryName
            // 
            this.lblSearchCategoryName.AutoSize = true;
            this.lblSearchCategoryName.Location = new System.Drawing.Point(14, 13);
            this.lblSearchCategoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchCategoryName.Name = "lblSearchCategoryName";
            this.lblSearchCategoryName.Size = new System.Drawing.Size(67, 13);
            this.lblSearchCategoryName.TabIndex = 0;
            this.lblSearchCategoryName.Text = "Kategori İsmi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 33);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1155, 383);
            this.dataGridView2.TabIndex = 3;
            // 
            // pnlEkle
            // 
            this.pnlEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlEkle.Controls.Add(this.cmbBoxAddCategoryUpperCategory);
            this.pnlEkle.Controls.Add(this.btnAddCategoryAdd);
            this.pnlEkle.Controls.Add(this.txtAddCategoryName);
            this.pnlEkle.Controls.Add(this.lblAddCategoryName);
            this.pnlEkle.Controls.Add(this.lblAddCategoryUpperCategory);
            this.pnlEkle.Location = new System.Drawing.Point(112, 20);
            this.pnlEkle.Name = "pnlEkle";
            this.pnlEkle.Size = new System.Drawing.Size(1159, 416);
            this.pnlEkle.TabIndex = 8;
            // 
            // cmbBoxAddCategoryUpperCategory
            // 
            this.cmbBoxAddCategoryUpperCategory.FormattingEnabled = true;
            this.cmbBoxAddCategoryUpperCategory.Location = new System.Drawing.Point(456, 141);
            this.cmbBoxAddCategoryUpperCategory.Name = "cmbBoxAddCategoryUpperCategory";
            this.cmbBoxAddCategoryUpperCategory.Size = new System.Drawing.Size(170, 21);
            this.cmbBoxAddCategoryUpperCategory.TabIndex = 38;
            // 
            // btnAddCategoryAdd
            // 
            this.btnAddCategoryAdd.Location = new System.Drawing.Point(333, 177);
            this.btnAddCategoryAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCategoryAdd.Name = "btnAddCategoryAdd";
            this.btnAddCategoryAdd.Size = new System.Drawing.Size(109, 34);
            this.btnAddCategoryAdd.TabIndex = 37;
            this.btnAddCategoryAdd.Text = "Ekle";
            this.btnAddCategoryAdd.UseVisualStyleBackColor = true;
            this.btnAddCategoryAdd.Click += new System.EventHandler(this.btnAddCategoryAdd_Click);
            // 
            // txtAddCategoryName
            // 
            this.txtAddCategoryName.Location = new System.Drawing.Point(200, 142);
            this.txtAddCategoryName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddCategoryName.Name = "txtAddCategoryName";
            this.txtAddCategoryName.Size = new System.Drawing.Size(170, 20);
            this.txtAddCategoryName.TabIndex = 29;
            // 
            // lblAddCategoryName
            // 
            this.lblAddCategoryName.AutoSize = true;
            this.lblAddCategoryName.Location = new System.Drawing.Point(132, 145);
            this.lblAddCategoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddCategoryName.Name = "lblAddCategoryName";
            this.lblAddCategoryName.Size = new System.Drawing.Size(67, 13);
            this.lblAddCategoryName.TabIndex = 28;
            this.lblAddCategoryName.Text = "Kategori İsim";
            // 
            // lblAddCategoryUpperCategory
            // 
            this.lblAddCategoryUpperCategory.AutoSize = true;
            this.lblAddCategoryUpperCategory.Location = new System.Drawing.Point(386, 145);
            this.lblAddCategoryUpperCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddCategoryUpperCategory.Name = "lblAddCategoryUpperCategory";
            this.lblAddCategoryUpperCategory.Size = new System.Drawing.Size(65, 13);
            this.lblAddCategoryUpperCategory.TabIndex = 26;
            this.lblAddCategoryUpperCategory.Text = "Üst Kategori";
            // 
            // pnlGuncelle
            // 
            this.pnlGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlGuncelle.Controls.Add(this.cmbBoxUpdateCategoryUpperCategory);
            this.pnlGuncelle.Controls.Add(this.btnUpdateCategoryUpdate);
            this.pnlGuncelle.Controls.Add(this.txtUpdateCategoryName);
            this.pnlGuncelle.Controls.Add(this.lblUpdateCategoryName);
            this.pnlGuncelle.Controls.Add(this.btnUpdateCategorySearch);
            this.pnlGuncelle.Controls.Add(this.lblUpdateCategoryEmail);
            this.pnlGuncelle.Location = new System.Drawing.Point(112, 20);
            this.pnlGuncelle.Name = "pnlGuncelle";
            this.pnlGuncelle.Size = new System.Drawing.Size(1159, 416);
            this.pnlGuncelle.TabIndex = 9;
            // 
            // cmbBoxUpdateCategoryUpperCategory
            // 
            this.cmbBoxUpdateCategoryUpperCategory.FormattingEnabled = true;
            this.cmbBoxUpdateCategoryUpperCategory.Location = new System.Drawing.Point(256, 118);
            this.cmbBoxUpdateCategoryUpperCategory.Name = "cmbBoxUpdateCategoryUpperCategory";
            this.cmbBoxUpdateCategoryUpperCategory.Size = new System.Drawing.Size(170, 21);
            this.cmbBoxUpdateCategoryUpperCategory.TabIndex = 25;
            // 
            // btnUpdateCategoryUpdate
            // 
            this.btnUpdateCategoryUpdate.Location = new System.Drawing.Point(389, 161);
            this.btnUpdateCategoryUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateCategoryUpdate.Name = "btnUpdateCategoryUpdate";
            this.btnUpdateCategoryUpdate.Size = new System.Drawing.Size(109, 34);
            this.btnUpdateCategoryUpdate.TabIndex = 24;
            this.btnUpdateCategoryUpdate.Text = "Güncelle";
            this.btnUpdateCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnUpdateCategoryUpdate.Click += new System.EventHandler(this.btnUpdateCategoryUpdate_Click);
            // 
            // txtUpdateCategoryName
            // 
            this.txtUpdateCategoryName.Location = new System.Drawing.Point(512, 118);
            this.txtUpdateCategoryName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUpdateCategoryName.Name = "txtUpdateCategoryName";
            this.txtUpdateCategoryName.Size = new System.Drawing.Size(170, 20);
            this.txtUpdateCategoryName.TabIndex = 19;
            // 
            // lblUpdateCategoryName
            // 
            this.lblUpdateCategoryName.AutoSize = true;
            this.lblUpdateCategoryName.Location = new System.Drawing.Point(444, 120);
            this.lblUpdateCategoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateCategoryName.Name = "lblUpdateCategoryName";
            this.lblUpdateCategoryName.Size = new System.Drawing.Size(67, 13);
            this.lblUpdateCategoryName.TabIndex = 18;
            this.lblUpdateCategoryName.Text = "Kategori İsim";
            // 
            // btnUpdateCategorySearch
            // 
            this.btnUpdateCategorySearch.Location = new System.Drawing.Point(686, 119);
            this.btnUpdateCategorySearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateCategorySearch.Name = "btnUpdateCategorySearch";
            this.btnUpdateCategorySearch.Size = new System.Drawing.Size(56, 19);
            this.btnUpdateCategorySearch.TabIndex = 17;
            this.btnUpdateCategorySearch.Text = "Ara";
            this.btnUpdateCategorySearch.UseVisualStyleBackColor = true;
            this.btnUpdateCategorySearch.Click += new System.EventHandler(this.btnUpdateCategorySearch_Click);
            // 
            // lblUpdateCategoryEmail
            // 
            this.lblUpdateCategoryEmail.AutoSize = true;
            this.lblUpdateCategoryEmail.Location = new System.Drawing.Point(187, 121);
            this.lblUpdateCategoryEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateCategoryEmail.Name = "lblUpdateCategoryEmail";
            this.lblUpdateCategoryEmail.Size = new System.Drawing.Size(65, 13);
            this.lblUpdateCategoryEmail.TabIndex = 15;
            this.lblUpdateCategoryEmail.Text = "Üst Kategori";
            // 
            // pnlSil
            // 
            this.pnlSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlSil.Controls.Add(this.cmbBoxDeleteCategoryUpperCategory);
            this.pnlSil.Controls.Add(this.btnDeleteCategoryDelete);
            this.pnlSil.Controls.Add(this.lblDeleteCategoryUpperCategory);
            this.pnlSil.Controls.Add(this.btnDeleteCategorySearch);
            this.pnlSil.Controls.Add(this.txtDeleteCategoryName);
            this.pnlSil.Controls.Add(this.lblDeleteCategoryName);
            this.pnlSil.Location = new System.Drawing.Point(112, 20);
            this.pnlSil.Name = "pnlSil";
            this.pnlSil.Size = new System.Drawing.Size(1159, 416);
            this.pnlSil.TabIndex = 10;
            // 
            // cmbBoxDeleteCategoryUpperCategory
            // 
            this.cmbBoxDeleteCategoryUpperCategory.FormattingEnabled = true;
            this.cmbBoxDeleteCategoryUpperCategory.Location = new System.Drawing.Point(262, 153);
            this.cmbBoxDeleteCategoryUpperCategory.Name = "cmbBoxDeleteCategoryUpperCategory";
            this.cmbBoxDeleteCategoryUpperCategory.Size = new System.Drawing.Size(170, 21);
            this.cmbBoxDeleteCategoryUpperCategory.TabIndex = 15;
            // 
            // btnDeleteCategoryDelete
            // 
            this.btnDeleteCategoryDelete.Location = new System.Drawing.Point(282, 193);
            this.btnDeleteCategoryDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteCategoryDelete.Name = "btnDeleteCategoryDelete";
            this.btnDeleteCategoryDelete.Size = new System.Drawing.Size(109, 34);
            this.btnDeleteCategoryDelete.TabIndex = 14;
            this.btnDeleteCategoryDelete.Text = "Sil";
            this.btnDeleteCategoryDelete.UseVisualStyleBackColor = true;
            this.btnDeleteCategoryDelete.Click += new System.EventHandler(this.btnDeleteCategoryDelete_Click);
            // 
            // lblDeleteCategoryUpperCategory
            // 
            this.lblDeleteCategoryUpperCategory.AutoSize = true;
            this.lblDeleteCategoryUpperCategory.Location = new System.Drawing.Point(194, 155);
            this.lblDeleteCategoryUpperCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteCategoryUpperCategory.Name = "lblDeleteCategoryUpperCategory";
            this.lblDeleteCategoryUpperCategory.Size = new System.Drawing.Size(65, 13);
            this.lblDeleteCategoryUpperCategory.TabIndex = 6;
            this.lblDeleteCategoryUpperCategory.Text = "Üst Kategori";
            // 
            // btnDeleteCategorySearch
            // 
            this.btnDeleteCategorySearch.Location = new System.Drawing.Point(442, 129);
            this.btnDeleteCategorySearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteCategorySearch.Name = "btnDeleteCategorySearch";
            this.btnDeleteCategorySearch.Size = new System.Drawing.Size(56, 19);
            this.btnDeleteCategorySearch.TabIndex = 5;
            this.btnDeleteCategorySearch.Text = "Ara";
            this.btnDeleteCategorySearch.UseVisualStyleBackColor = true;
            this.btnDeleteCategorySearch.Click += new System.EventHandler(this.btnDeleteCategorySearch_Click);
            // 
            // txtDeleteCategoryName
            // 
            this.txtDeleteCategoryName.Location = new System.Drawing.Point(262, 128);
            this.txtDeleteCategoryName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeleteCategoryName.Name = "txtDeleteCategoryName";
            this.txtDeleteCategoryName.Size = new System.Drawing.Size(170, 20);
            this.txtDeleteCategoryName.TabIndex = 4;
            // 
            // lblDeleteCategoryName
            // 
            this.lblDeleteCategoryName.AutoSize = true;
            this.lblDeleteCategoryName.Location = new System.Drawing.Point(194, 131);
            this.lblDeleteCategoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeleteCategoryName.Name = "lblDeleteCategoryName";
            this.lblDeleteCategoryName.Size = new System.Drawing.Size(67, 13);
            this.lblDeleteCategoryName.TabIndex = 3;
            this.lblDeleteCategoryName.Text = "Kategori İsmi";
            // 
            // KategoriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 501);
            this.Controls.Add(this.gbSupplement);
            this.Controls.Add(this.pnlSil);
            this.Controls.Add(this.pnlGuncelle);
            this.Controls.Add(this.pnlListele);
            this.Controls.Add(this.pnlEkle);
            this.Controls.Add(this.pnlAra);
            this.Name = "KategoriIslemleri";
            this.Text = "KategoriIslemleri";
            this.gbSupplement.ResumeLayout(false);
            this.pnlListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAra.ResumeLayout(false);
            this.pnlAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnlEkle.ResumeLayout(false);
            this.pnlEkle.PerformLayout();
            this.pnlGuncelle.ResumeLayout(false);
            this.pnlGuncelle.PerformLayout();
            this.pnlSil.ResumeLayout(false);
            this.pnlSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSupplement;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel pnlListele;
        private System.Windows.Forms.Panel pnlAra;
        private System.Windows.Forms.Panel pnlEkle;
        private System.Windows.Forms.Panel pnlGuncelle;
        private System.Windows.Forms.Panel pnlSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSearchCategorySearch;
        private System.Windows.Forms.TextBox txtSearchCategoryName;
        private System.Windows.Forms.Label lblSearchCategoryName;
        private System.Windows.Forms.Button btnDeleteCategorySearch;
        private System.Windows.Forms.TextBox txtDeleteCategoryName;
        private System.Windows.Forms.Label lblDeleteCategoryName;
        private System.Windows.Forms.Button btnDeleteCategoryDelete;
        private System.Windows.Forms.Label lblDeleteCategoryUpperCategory;
        private System.Windows.Forms.Button btnUpdateCategoryUpdate;
        private System.Windows.Forms.TextBox txtUpdateCategoryName;
        private System.Windows.Forms.Label lblUpdateCategoryName;
        private System.Windows.Forms.Button btnUpdateCategorySearch;
        private System.Windows.Forms.Label lblUpdateCategoryEmail;
        private System.Windows.Forms.Button btnAddCategoryAdd;
        private System.Windows.Forms.TextBox txtAddCategoryName;
        private System.Windows.Forms.Label lblAddCategoryName;
        private System.Windows.Forms.Label lblAddCategoryUpperCategory;
        private System.Windows.Forms.ComboBox cmbBoxAddCategoryUpperCategory;
        private System.Windows.Forms.ComboBox cmbBoxUpdateCategoryUpperCategory;
        private System.Windows.Forms.ComboBox cmbBoxDeleteCategoryUpperCategory;
    }
}