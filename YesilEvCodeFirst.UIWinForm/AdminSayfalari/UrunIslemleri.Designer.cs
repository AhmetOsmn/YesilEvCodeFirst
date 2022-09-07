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
            this.lblUrunListelemeSayfasi = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlDeleteProduct = new System.Windows.Forms.Panel();
            this.lblUrunSilmeSayfasi = new System.Windows.Forms.Label();
            this.btnDeleteSearch = new System.Windows.Forms.Button();
            this.tbDeleteProductName = new System.Windows.Forms.TextBox();
            this.lblDeleteProductName = new System.Windows.Forms.Label();
            this.btnDeleteDelete = new System.Windows.Forms.Button();
            this.tbDeleteAdder = new System.Windows.Forms.TextBox();
            this.lblDeletyeAdder = new System.Windows.Forms.Label();
            this.tbDeleteCategory = new System.Windows.Forms.TextBox();
            this.tbDeleteSupplement = new System.Windows.Forms.TextBox();
            this.lblDeleteCategory = new System.Windows.Forms.Label();
            this.lblDeleteSupplier = new System.Windows.Forms.Label();
            this.tbDeleteBarcode = new System.Windows.Forms.TextBox();
            this.tbDeleteProductContent = new System.Windows.Forms.TextBox();
            this.lblDeleteBarcode = new System.Windows.Forms.Label();
            this.lblDeleteProductContent = new System.Windows.Forms.Label();
            this.pnlUrunEkle = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddProductContenPic = new System.Windows.Forms.Button();
            this.btnBackPic = new System.Windows.Forms.Button();
            this.btnFrontPic = new System.Windows.Forms.Button();
            this.tbProductContent = new System.Windows.Forms.TextBox();
            this.cbxSuppliers = new System.Windows.Forms.ComboBox();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lblProductContent = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlAra = new System.Windows.Forms.Panel();
            this.lblUrunAramaSayfasi = new System.Windows.Forms.Label();
            this.btnUrunuAra = new System.Windows.Forms.Button();
            this.lblUrunAra = new System.Windows.Forms.Label();
            this.tbUrunAra = new System.Windows.Forms.TextBox();
            this.dgvSearchProduct = new System.Windows.Forms.DataGridView();
            this.pnlApprove = new System.Windows.Forms.Panel();
            this.btnApproveOnayla = new System.Windows.Forms.Button();
            this.lblUrunOnaylamaSayfasi = new System.Windows.Forms.Label();
            this.dgvApprove = new System.Windows.Forms.DataGridView();
            this.pnlUrunGuncelle = new System.Windows.Forms.Panel();
            this.lblUrunGuncellemeSayfasi = new System.Windows.Forms.Label();
            this.btnUpdateBarcodeSearch = new System.Windows.Forms.Button();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.btnUpdateProductContentPic = new System.Windows.Forms.Button();
            this.btnUpdateBackPic = new System.Windows.Forms.Button();
            this.btnUpdateFrontPic = new System.Windows.Forms.Button();
            this.tbUpdateProductContent = new System.Windows.Forms.TextBox();
            this.cbxUpdateSuppliers = new System.Windows.Forms.ComboBox();
            this.cbxUpdateCategories = new System.Windows.Forms.ComboBox();
            this.tbUpdateBarcode = new System.Windows.Forms.TextBox();
            this.tbUpdateProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileDialogAddProductContent = new System.Windows.Forms.OpenFileDialog();
            this.FileDialogUpdateProductContent = new System.Windows.Forms.OpenFileDialog();
            this.FileDialogUpdateProductFront = new System.Windows.Forms.OpenFileDialog();
            this.FileDialogUpdateProductBack = new System.Windows.Forms.OpenFileDialog();
            this.FileDialogAddProductFront = new System.Windows.Forms.OpenFileDialog();
            this.FileDialogAddProductBack = new System.Windows.Forms.OpenFileDialog();
            this.gbProduct.SuspendLayout();
            this.pnlListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlDeleteProduct.SuspendLayout();
            this.pnlUrunEkle.SuspendLayout();
            this.pnlAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProduct)).BeginInit();
            this.pnlApprove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprove)).BeginInit();
            this.pnlUrunGuncelle.SuspendLayout();
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
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(6, 263);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 43);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pnlListele
            // 
            this.pnlListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlListele.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlListele.Controls.Add(this.lblUrunListelemeSayfasi);
            this.pnlListele.Controls.Add(this.dgvProducts);
            this.pnlListele.Location = new System.Drawing.Point(113, 12);
            this.pnlListele.Name = "pnlListele";
            this.pnlListele.Size = new System.Drawing.Size(1142, 426);
            this.pnlListele.TabIndex = 2;
            // 
            // lblUrunListelemeSayfasi
            // 
            this.lblUrunListelemeSayfasi.AutoSize = true;
            this.lblUrunListelemeSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunListelemeSayfasi.Location = new System.Drawing.Point(3, 7);
            this.lblUrunListelemeSayfasi.Name = "lblUrunListelemeSayfasi";
            this.lblUrunListelemeSayfasi.Size = new System.Drawing.Size(136, 13);
            this.lblUrunListelemeSayfasi.TabIndex = 2;
            this.lblUrunListelemeSayfasi.Text = "Ürün Listeleme Sayfası";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(3, 28);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(1136, 395);
            this.dgvProducts.TabIndex = 1;
            // 
            // pnlDeleteProduct
            // 
            this.pnlDeleteProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDeleteProduct.Controls.Add(this.lblUrunSilmeSayfasi);
            this.pnlDeleteProduct.Controls.Add(this.btnDeleteSearch);
            this.pnlDeleteProduct.Controls.Add(this.tbDeleteProductName);
            this.pnlDeleteProduct.Controls.Add(this.lblDeleteProductName);
            this.pnlDeleteProduct.Controls.Add(this.btnDeleteDelete);
            this.pnlDeleteProduct.Controls.Add(this.tbDeleteAdder);
            this.pnlDeleteProduct.Controls.Add(this.lblDeletyeAdder);
            this.pnlDeleteProduct.Controls.Add(this.tbDeleteCategory);
            this.pnlDeleteProduct.Controls.Add(this.tbDeleteSupplement);
            this.pnlDeleteProduct.Controls.Add(this.lblDeleteCategory);
            this.pnlDeleteProduct.Controls.Add(this.lblDeleteSupplier);
            this.pnlDeleteProduct.Controls.Add(this.tbDeleteBarcode);
            this.pnlDeleteProduct.Controls.Add(this.tbDeleteProductContent);
            this.pnlDeleteProduct.Controls.Add(this.lblDeleteBarcode);
            this.pnlDeleteProduct.Controls.Add(this.lblDeleteProductContent);
            this.pnlDeleteProduct.Location = new System.Drawing.Point(113, 12);
            this.pnlDeleteProduct.Name = "pnlDeleteProduct";
            this.pnlDeleteProduct.Size = new System.Drawing.Size(1148, 429);
            this.pnlDeleteProduct.TabIndex = 7;
            // 
            // lblUrunSilmeSayfasi
            // 
            this.lblUrunSilmeSayfasi.AutoSize = true;
            this.lblUrunSilmeSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSilmeSayfasi.Location = new System.Drawing.Point(3, 7);
            this.lblUrunSilmeSayfasi.Name = "lblUrunSilmeSayfasi";
            this.lblUrunSilmeSayfasi.Size = new System.Drawing.Size(113, 13);
            this.lblUrunSilmeSayfasi.TabIndex = 29;
            this.lblUrunSilmeSayfasi.Text = "Ürün Silme Sayfası";
            // 
            // btnDeleteSearch
            // 
            this.btnDeleteSearch.Location = new System.Drawing.Point(443, 96);
            this.btnDeleteSearch.Name = "btnDeleteSearch";
            this.btnDeleteSearch.Size = new System.Drawing.Size(75, 20);
            this.btnDeleteSearch.TabIndex = 28;
            this.btnDeleteSearch.Text = "Ara";
            this.btnDeleteSearch.UseVisualStyleBackColor = true;
            this.btnDeleteSearch.Click += new System.EventHandler(this.btnDeleteSearch_Click);
            // 
            // tbDeleteProductName
            // 
            this.tbDeleteProductName.Enabled = false;
            this.tbDeleteProductName.Location = new System.Drawing.Point(253, 127);
            this.tbDeleteProductName.Name = "tbDeleteProductName";
            this.tbDeleteProductName.Size = new System.Drawing.Size(172, 20);
            this.tbDeleteProductName.TabIndex = 27;
            // 
            // lblDeleteProductName
            // 
            this.lblDeleteProductName.AutoSize = true;
            this.lblDeleteProductName.Enabled = false;
            this.lblDeleteProductName.Location = new System.Drawing.Point(196, 131);
            this.lblDeleteProductName.Name = "lblDeleteProductName";
            this.lblDeleteProductName.Size = new System.Drawing.Size(51, 13);
            this.lblDeleteProductName.TabIndex = 26;
            this.lblDeleteProductName.Text = "Ürün Adı:";
            // 
            // btnDeleteDelete
            // 
            this.btnDeleteDelete.Enabled = false;
            this.btnDeleteDelete.Location = new System.Drawing.Point(253, 292);
            this.btnDeleteDelete.Name = "btnDeleteDelete";
            this.btnDeleteDelete.Size = new System.Drawing.Size(172, 42);
            this.btnDeleteDelete.TabIndex = 25;
            this.btnDeleteDelete.Text = "Ürünü Sil";
            this.btnDeleteDelete.UseVisualStyleBackColor = true;
            this.btnDeleteDelete.Click += new System.EventHandler(this.btnDeleteDelete_Click);
            // 
            // tbDeleteAdder
            // 
            this.tbDeleteAdder.Enabled = false;
            this.tbDeleteAdder.Location = new System.Drawing.Point(253, 261);
            this.tbDeleteAdder.Name = "tbDeleteAdder";
            this.tbDeleteAdder.Size = new System.Drawing.Size(172, 20);
            this.tbDeleteAdder.TabIndex = 24;
            // 
            // lblDeletyeAdder
            // 
            this.lblDeletyeAdder.AutoSize = true;
            this.lblDeletyeAdder.Enabled = false;
            this.lblDeletyeAdder.Location = new System.Drawing.Point(199, 264);
            this.lblDeletyeAdder.Name = "lblDeletyeAdder";
            this.lblDeletyeAdder.Size = new System.Drawing.Size(48, 13);
            this.lblDeletyeAdder.TabIndex = 23;
            this.lblDeletyeAdder.Text = "Ekleyen:";
            // 
            // tbDeleteCategory
            // 
            this.tbDeleteCategory.Enabled = false;
            this.tbDeleteCategory.Location = new System.Drawing.Point(253, 235);
            this.tbDeleteCategory.Name = "tbDeleteCategory";
            this.tbDeleteCategory.Size = new System.Drawing.Size(172, 20);
            this.tbDeleteCategory.TabIndex = 22;
            // 
            // tbDeleteSupplement
            // 
            this.tbDeleteSupplement.Enabled = false;
            this.tbDeleteSupplement.Location = new System.Drawing.Point(253, 209);
            this.tbDeleteSupplement.Name = "tbDeleteSupplement";
            this.tbDeleteSupplement.Size = new System.Drawing.Size(172, 20);
            this.tbDeleteSupplement.TabIndex = 21;
            // 
            // lblDeleteCategory
            // 
            this.lblDeleteCategory.AutoSize = true;
            this.lblDeleteCategory.Enabled = false;
            this.lblDeleteCategory.Location = new System.Drawing.Point(198, 238);
            this.lblDeleteCategory.Name = "lblDeleteCategory";
            this.lblDeleteCategory.Size = new System.Drawing.Size(49, 13);
            this.lblDeleteCategory.TabIndex = 20;
            this.lblDeleteCategory.Text = "Kategori:";
            // 
            // lblDeleteSupplier
            // 
            this.lblDeleteSupplier.AutoSize = true;
            this.lblDeleteSupplier.Enabled = false;
            this.lblDeleteSupplier.Location = new System.Drawing.Point(207, 212);
            this.lblDeleteSupplier.Name = "lblDeleteSupplier";
            this.lblDeleteSupplier.Size = new System.Drawing.Size(40, 13);
            this.lblDeleteSupplier.TabIndex = 19;
            this.lblDeleteSupplier.Text = "Üretici:";
            // 
            // tbDeleteBarcode
            // 
            this.tbDeleteBarcode.Location = new System.Drawing.Point(253, 96);
            this.tbDeleteBarcode.Name = "tbDeleteBarcode";
            this.tbDeleteBarcode.Size = new System.Drawing.Size(172, 20);
            this.tbDeleteBarcode.TabIndex = 18;
            // 
            // tbDeleteProductContent
            // 
            this.tbDeleteProductContent.Enabled = false;
            this.tbDeleteProductContent.Location = new System.Drawing.Point(253, 155);
            this.tbDeleteProductContent.Multiline = true;
            this.tbDeleteProductContent.Name = "tbDeleteProductContent";
            this.tbDeleteProductContent.Size = new System.Drawing.Size(172, 48);
            this.tbDeleteProductContent.TabIndex = 17;
            // 
            // lblDeleteBarcode
            // 
            this.lblDeleteBarcode.AutoSize = true;
            this.lblDeleteBarcode.Location = new System.Drawing.Point(186, 100);
            this.lblDeleteBarcode.Name = "lblDeleteBarcode";
            this.lblDeleteBarcode.Size = new System.Drawing.Size(61, 13);
            this.lblDeleteBarcode.TabIndex = 16;
            this.lblDeleteBarcode.Text = "Barkod No:";
            // 
            // lblDeleteProductContent
            // 
            this.lblDeleteProductContent.AutoSize = true;
            this.lblDeleteProductContent.Enabled = false;
            this.lblDeleteProductContent.Location = new System.Drawing.Point(183, 157);
            this.lblDeleteProductContent.Name = "lblDeleteProductContent";
            this.lblDeleteProductContent.Size = new System.Drawing.Size(64, 13);
            this.lblDeleteProductContent.TabIndex = 15;
            this.lblDeleteProductContent.Text = "Ürün İçeriği:";
            // 
            // pnlUrunEkle
            // 
            this.pnlUrunEkle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUrunEkle.Controls.Add(this.label6);
            this.pnlUrunEkle.Controls.Add(this.btnSave);
            this.pnlUrunEkle.Controls.Add(this.btnAddProductContenPic);
            this.pnlUrunEkle.Controls.Add(this.btnBackPic);
            this.pnlUrunEkle.Controls.Add(this.btnFrontPic);
            this.pnlUrunEkle.Controls.Add(this.tbProductContent);
            this.pnlUrunEkle.Controls.Add(this.cbxSuppliers);
            this.pnlUrunEkle.Controls.Add(this.cbxCategories);
            this.pnlUrunEkle.Controls.Add(this.tbBarcode);
            this.pnlUrunEkle.Controls.Add(this.tbProductName);
            this.pnlUrunEkle.Controls.Add(this.lblProductContent);
            this.pnlUrunEkle.Controls.Add(this.lblSupplier);
            this.pnlUrunEkle.Controls.Add(this.lblCategory);
            this.pnlUrunEkle.Controls.Add(this.lblBarcode);
            this.pnlUrunEkle.Controls.Add(this.lblProductName);
            this.pnlUrunEkle.Location = new System.Drawing.Point(113, 12);
            this.pnlUrunEkle.Name = "pnlUrunEkle";
            this.pnlUrunEkle.Size = new System.Drawing.Size(1148, 429);
            this.pnlUrunEkle.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ürün Ekleme Sayfası";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(229, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 57);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddProductContenPic
            // 
            this.btnAddProductContenPic.Location = new System.Drawing.Point(407, 153);
            this.btnAddProductContenPic.Name = "btnAddProductContenPic";
            this.btnAddProductContenPic.Size = new System.Drawing.Size(79, 56);
            this.btnAddProductContenPic.TabIndex = 20;
            this.btnAddProductContenPic.Text = "İçerik Fotoğraf";
            this.btnAddProductContenPic.UseVisualStyleBackColor = true;
            this.btnAddProductContenPic.Click += new System.EventHandler(this.btnAddProductContenPic_Click);
            // 
            // btnBackPic
            // 
            this.btnBackPic.Location = new System.Drawing.Point(322, 215);
            this.btnBackPic.Name = "btnBackPic";
            this.btnBackPic.Size = new System.Drawing.Size(79, 56);
            this.btnBackPic.TabIndex = 19;
            this.btnBackPic.Text = "Arka Fotoğraf";
            this.btnBackPic.UseVisualStyleBackColor = true;
            this.btnBackPic.Click += new System.EventHandler(this.btnBackPic_Click);
            // 
            // btnFrontPic
            // 
            this.btnFrontPic.Location = new System.Drawing.Point(229, 215);
            this.btnFrontPic.Name = "btnFrontPic";
            this.btnFrontPic.Size = new System.Drawing.Size(79, 56);
            this.btnFrontPic.TabIndex = 18;
            this.btnFrontPic.Text = "Ön Fotoğraf";
            this.btnFrontPic.UseVisualStyleBackColor = true;
            this.btnFrontPic.Click += new System.EventHandler(this.btnFrontPic_Click);
            // 
            // tbProductContent
            // 
            this.tbProductContent.Location = new System.Drawing.Point(229, 153);
            this.tbProductContent.Multiline = true;
            this.tbProductContent.Name = "tbProductContent";
            this.tbProductContent.Size = new System.Drawing.Size(172, 56);
            this.tbProductContent.TabIndex = 17;
            // 
            // cbxSuppliers
            // 
            this.cbxSuppliers.FormattingEnabled = true;
            this.cbxSuppliers.Location = new System.Drawing.Point(229, 126);
            this.cbxSuppliers.Name = "cbxSuppliers";
            this.cbxSuppliers.Size = new System.Drawing.Size(172, 21);
            this.cbxSuppliers.TabIndex = 16;
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(229, 99);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(172, 21);
            this.cbxCategories.TabIndex = 15;
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(229, 73);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(172, 20);
            this.tbBarcode.TabIndex = 14;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(229, 47);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(172, 20);
            this.tbProductName.TabIndex = 13;
            // 
            // lblProductContent
            // 
            this.lblProductContent.AutoSize = true;
            this.lblProductContent.Location = new System.Drawing.Point(148, 156);
            this.lblProductContent.Name = "lblProductContent";
            this.lblProductContent.Size = new System.Drawing.Size(75, 13);
            this.lblProductContent.TabIndex = 10;
            this.lblProductContent.Text = "Ürün İçerikleri:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(183, 129);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(40, 13);
            this.lblSupplier.TabIndex = 9;
            this.lblSupplier.Text = "Üretici:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(174, 103);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Kategori:";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(162, 80);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(61, 13);
            this.lblBarcode.TabIndex = 7;
            this.lblBarcode.Text = "Barkod No:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(172, 50);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(51, 13);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Ürün Adı:";
            // 
            // pnlAra
            // 
            this.pnlAra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAra.Controls.Add(this.lblUrunAramaSayfasi);
            this.pnlAra.Controls.Add(this.btnUrunuAra);
            this.pnlAra.Controls.Add(this.lblUrunAra);
            this.pnlAra.Controls.Add(this.tbUrunAra);
            this.pnlAra.Controls.Add(this.dgvSearchProduct);
            this.pnlAra.Location = new System.Drawing.Point(113, 12);
            this.pnlAra.Name = "pnlAra";
            this.pnlAra.Size = new System.Drawing.Size(1142, 429);
            this.pnlAra.TabIndex = 1;
            // 
            // lblUrunAramaSayfasi
            // 
            this.lblUrunAramaSayfasi.AutoSize = true;
            this.lblUrunAramaSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAramaSayfasi.Location = new System.Drawing.Point(3, 7);
            this.lblUrunAramaSayfasi.Name = "lblUrunAramaSayfasi";
            this.lblUrunAramaSayfasi.Size = new System.Drawing.Size(118, 13);
            this.lblUrunAramaSayfasi.TabIndex = 5;
            this.lblUrunAramaSayfasi.Text = "Ürün Arama Sayfası";
            // 
            // btnUrunuAra
            // 
            this.btnUrunuAra.Location = new System.Drawing.Point(651, 4);
            this.btnUrunuAra.Name = "btnUrunuAra";
            this.btnUrunuAra.Size = new System.Drawing.Size(75, 20);
            this.btnUrunuAra.TabIndex = 3;
            this.btnUrunuAra.Text = "Ara";
            this.btnUrunuAra.UseVisualStyleBackColor = true;
            this.btnUrunuAra.Click += new System.EventHandler(this.btnUrunuAra_Click);
            // 
            // lblUrunAra
            // 
            this.lblUrunAra.AutoSize = true;
            this.lblUrunAra.Location = new System.Drawing.Point(355, 7);
            this.lblUrunAra.Name = "lblUrunAra";
            this.lblUrunAra.Size = new System.Drawing.Size(82, 13);
            this.lblUrunAra.TabIndex = 1;
            this.lblUrunAra.Text = "Urun Adı Giriniz:";
            // 
            // tbUrunAra
            // 
            this.tbUrunAra.Location = new System.Drawing.Point(443, 4);
            this.tbUrunAra.Name = "tbUrunAra";
            this.tbUrunAra.Size = new System.Drawing.Size(187, 20);
            this.tbUrunAra.TabIndex = 0;
            // 
            // dgvSearchProduct
            // 
            this.dgvSearchProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchProduct.Location = new System.Drawing.Point(3, 43);
            this.dgvSearchProduct.Name = "dgvSearchProduct";
            this.dgvSearchProduct.ReadOnly = true;
            this.dgvSearchProduct.Size = new System.Drawing.Size(1136, 382);
            this.dgvSearchProduct.TabIndex = 4;
            // 
            // pnlApprove
            // 
            this.pnlApprove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlApprove.Controls.Add(this.btnApproveOnayla);
            this.pnlApprove.Controls.Add(this.lblUrunOnaylamaSayfasi);
            this.pnlApprove.Controls.Add(this.dgvApprove);
            this.pnlApprove.Location = new System.Drawing.Point(113, 12);
            this.pnlApprove.Name = "pnlApprove";
            this.pnlApprove.Size = new System.Drawing.Size(1142, 426);
            this.pnlApprove.TabIndex = 4;
            // 
            // btnApproveOnayla
            // 
            this.btnApproveOnayla.Location = new System.Drawing.Point(1047, 3);
            this.btnApproveOnayla.Name = "btnApproveOnayla";
            this.btnApproveOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnApproveOnayla.TabIndex = 8;
            this.btnApproveOnayla.Text = "Onayla";
            this.btnApproveOnayla.UseVisualStyleBackColor = true;
            this.btnApproveOnayla.Click += new System.EventHandler(this.btnApproveOnayla_Click);
            // 
            // lblUrunOnaylamaSayfasi
            // 
            this.lblUrunOnaylamaSayfasi.AutoSize = true;
            this.lblUrunOnaylamaSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunOnaylamaSayfasi.Location = new System.Drawing.Point(3, 7);
            this.lblUrunOnaylamaSayfasi.Name = "lblUrunOnaylamaSayfasi";
            this.lblUrunOnaylamaSayfasi.Size = new System.Drawing.Size(138, 13);
            this.lblUrunOnaylamaSayfasi.TabIndex = 6;
            this.lblUrunOnaylamaSayfasi.Text = "Ürün Onaylama Sayfası";
            // 
            // dgvApprove
            // 
            this.dgvApprove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApprove.Location = new System.Drawing.Point(5, 28);
            this.dgvApprove.Name = "dgvApprove";
            this.dgvApprove.Size = new System.Drawing.Size(1139, 393);
            this.dgvApprove.TabIndex = 5;
            // 
            // pnlUrunGuncelle
            // 
            this.pnlUrunGuncelle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlUrunGuncelle.Controls.Add(this.lblUrunGuncellemeSayfasi);
            this.pnlUrunGuncelle.Controls.Add(this.btnUpdateBarcodeSearch);
            this.pnlUrunGuncelle.Controls.Add(this.btnUpdateSave);
            this.pnlUrunGuncelle.Controls.Add(this.btnUpdateProductContentPic);
            this.pnlUrunGuncelle.Controls.Add(this.btnUpdateBackPic);
            this.pnlUrunGuncelle.Controls.Add(this.btnUpdateFrontPic);
            this.pnlUrunGuncelle.Controls.Add(this.tbUpdateProductContent);
            this.pnlUrunGuncelle.Controls.Add(this.cbxUpdateSuppliers);
            this.pnlUrunGuncelle.Controls.Add(this.cbxUpdateCategories);
            this.pnlUrunGuncelle.Controls.Add(this.tbUpdateBarcode);
            this.pnlUrunGuncelle.Controls.Add(this.tbUpdateProductName);
            this.pnlUrunGuncelle.Controls.Add(this.label1);
            this.pnlUrunGuncelle.Controls.Add(this.label2);
            this.pnlUrunGuncelle.Controls.Add(this.label3);
            this.pnlUrunGuncelle.Controls.Add(this.label4);
            this.pnlUrunGuncelle.Controls.Add(this.label5);
            this.pnlUrunGuncelle.Location = new System.Drawing.Point(113, 12);
            this.pnlUrunGuncelle.Name = "pnlUrunGuncelle";
            this.pnlUrunGuncelle.Size = new System.Drawing.Size(1148, 426);
            this.pnlUrunGuncelle.TabIndex = 6;
            // 
            // lblUrunGuncellemeSayfasi
            // 
            this.lblUrunGuncellemeSayfasi.AutoSize = true;
            this.lblUrunGuncellemeSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunGuncellemeSayfasi.Location = new System.Drawing.Point(3, 7);
            this.lblUrunGuncellemeSayfasi.Name = "lblUrunGuncellemeSayfasi";
            this.lblUrunGuncellemeSayfasi.Size = new System.Drawing.Size(149, 13);
            this.lblUrunGuncellemeSayfasi.TabIndex = 23;
            this.lblUrunGuncellemeSayfasi.Text = "Ürün Güncelleme Sayfası";
            // 
            // btnUpdateBarcodeSearch
            // 
            this.btnUpdateBarcodeSearch.Location = new System.Drawing.Point(407, 39);
            this.btnUpdateBarcodeSearch.Name = "btnUpdateBarcodeSearch";
            this.btnUpdateBarcodeSearch.Size = new System.Drawing.Size(79, 22);
            this.btnUpdateBarcodeSearch.TabIndex = 22;
            this.btnUpdateBarcodeSearch.Text = "Ara";
            this.btnUpdateBarcodeSearch.UseVisualStyleBackColor = true;
            this.btnUpdateBarcodeSearch.Click += new System.EventHandler(this.btnUpdateBarcodeSearch_Click);
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Enabled = false;
            this.btnUpdateSave.Location = new System.Drawing.Point(229, 290);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(172, 57);
            this.btnUpdateSave.TabIndex = 21;
            this.btnUpdateSave.Text = "Kaydet";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // btnUpdateProductContentPic
            // 
            this.btnUpdateProductContentPic.Enabled = false;
            this.btnUpdateProductContentPic.Location = new System.Drawing.Point(407, 153);
            this.btnUpdateProductContentPic.Name = "btnUpdateProductContentPic";
            this.btnUpdateProductContentPic.Size = new System.Drawing.Size(79, 56);
            this.btnUpdateProductContentPic.TabIndex = 20;
            this.btnUpdateProductContentPic.Text = "İçerik Fotoğraf";
            this.btnUpdateProductContentPic.UseVisualStyleBackColor = true;
            this.btnUpdateProductContentPic.Click += new System.EventHandler(this.btnUpdateProductContentPic_Click);
            // 
            // btnUpdateBackPic
            // 
            this.btnUpdateBackPic.Enabled = false;
            this.btnUpdateBackPic.Location = new System.Drawing.Point(322, 215);
            this.btnUpdateBackPic.Name = "btnUpdateBackPic";
            this.btnUpdateBackPic.Size = new System.Drawing.Size(79, 56);
            this.btnUpdateBackPic.TabIndex = 19;
            this.btnUpdateBackPic.Text = "Arka Fotoğraf";
            this.btnUpdateBackPic.UseVisualStyleBackColor = true;
            this.btnUpdateBackPic.Click += new System.EventHandler(this.btnUpdateBackPic_Click);
            // 
            // btnUpdateFrontPic
            // 
            this.btnUpdateFrontPic.Enabled = false;
            this.btnUpdateFrontPic.Location = new System.Drawing.Point(229, 215);
            this.btnUpdateFrontPic.Name = "btnUpdateFrontPic";
            this.btnUpdateFrontPic.Size = new System.Drawing.Size(79, 56);
            this.btnUpdateFrontPic.TabIndex = 18;
            this.btnUpdateFrontPic.Text = "Ön Fotoğraf";
            this.btnUpdateFrontPic.UseVisualStyleBackColor = true;
            this.btnUpdateFrontPic.Click += new System.EventHandler(this.btnUpdateFrontPic_Click);
            // 
            // tbUpdateProductContent
            // 
            this.tbUpdateProductContent.Enabled = false;
            this.tbUpdateProductContent.Location = new System.Drawing.Point(229, 153);
            this.tbUpdateProductContent.Multiline = true;
            this.tbUpdateProductContent.Name = "tbUpdateProductContent";
            this.tbUpdateProductContent.Size = new System.Drawing.Size(172, 56);
            this.tbUpdateProductContent.TabIndex = 17;
            // 
            // cbxUpdateSuppliers
            // 
            this.cbxUpdateSuppliers.Enabled = false;
            this.cbxUpdateSuppliers.FormattingEnabled = true;
            this.cbxUpdateSuppliers.Location = new System.Drawing.Point(229, 126);
            this.cbxUpdateSuppliers.Name = "cbxUpdateSuppliers";
            this.cbxUpdateSuppliers.Size = new System.Drawing.Size(172, 21);
            this.cbxUpdateSuppliers.TabIndex = 16;
            // 
            // cbxUpdateCategories
            // 
            this.cbxUpdateCategories.Enabled = false;
            this.cbxUpdateCategories.FormattingEnabled = true;
            this.cbxUpdateCategories.Location = new System.Drawing.Point(229, 99);
            this.cbxUpdateCategories.Name = "cbxUpdateCategories";
            this.cbxUpdateCategories.Size = new System.Drawing.Size(172, 21);
            this.cbxUpdateCategories.TabIndex = 15;
            // 
            // tbUpdateBarcode
            // 
            this.tbUpdateBarcode.Location = new System.Drawing.Point(229, 41);
            this.tbUpdateBarcode.Name = "tbUpdateBarcode";
            this.tbUpdateBarcode.Size = new System.Drawing.Size(172, 20);
            this.tbUpdateBarcode.TabIndex = 14;
            // 
            // tbUpdateProductName
            // 
            this.tbUpdateProductName.Enabled = false;
            this.tbUpdateProductName.Location = new System.Drawing.Point(229, 73);
            this.tbUpdateProductName.Name = "tbUpdateProductName";
            this.tbUpdateProductName.Size = new System.Drawing.Size(172, 20);
            this.tbUpdateProductName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün İçerikleri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Üretici:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Barkod No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ürün Adı:";
            // 
            // FileDialogAddProductContent
            // 
            this.FileDialogAddProductContent.FileName = "openFileDialog1";
            // 
            // FileDialogUpdateProductContent
            // 
            this.FileDialogUpdateProductContent.FileName = "openFileDialog2";
            // 
            // FileDialogUpdateProductFront
            // 
            this.FileDialogUpdateProductFront.FileName = "openFileDialog3";
            // 
            // FileDialogUpdateProductBack
            // 
            this.FileDialogUpdateProductBack.FileName = "openFileDialog4";
            // 
            // FileDialogAddProductFront
            // 
            this.FileDialogAddProductFront.FileName = "openFileDialog5";
            // 
            // FileDialogAddProductBack
            // 
            this.FileDialogAddProductBack.FileName = "openFileDialog6";
            // 
            // UrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 453);
            this.Controls.Add(this.gbProduct);
            this.Controls.Add(this.pnlUrunEkle);
            this.Controls.Add(this.pnlListele);
            this.Controls.Add(this.pnlAra);
            this.Controls.Add(this.pnlApprove);
            this.Controls.Add(this.pnlUrunGuncelle);
            this.Controls.Add(this.pnlDeleteProduct);
            this.Name = "UrunIslemleri";
            this.Text = "UrunIslemleri";
            this.gbProduct.ResumeLayout(false);
            this.pnlListele.ResumeLayout(false);
            this.pnlListele.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlDeleteProduct.ResumeLayout(false);
            this.pnlDeleteProduct.PerformLayout();
            this.pnlUrunEkle.ResumeLayout(false);
            this.pnlUrunEkle.PerformLayout();
            this.pnlAra.ResumeLayout(false);
            this.pnlAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProduct)).EndInit();
            this.pnlApprove.ResumeLayout(false);
            this.pnlApprove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApprove)).EndInit();
            this.pnlUrunGuncelle.ResumeLayout(false);
            this.pnlUrunGuncelle.PerformLayout();
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
        private System.Windows.Forms.Panel pnlAra;
        private System.Windows.Forms.Label lblUrunAra;
        private System.Windows.Forms.TextBox tbUrunAra;
        private System.Windows.Forms.Button btnUrunuAra;
        private System.Windows.Forms.Panel pnlApprove;
        private System.Windows.Forms.DataGridView dgvApprove;
        private System.Windows.Forms.Panel pnlUrunEkle;
        private System.Windows.Forms.Label lblProductContent;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddProductContenPic;
        private System.Windows.Forms.Button btnBackPic;
        private System.Windows.Forms.Button btnFrontPic;
        private System.Windows.Forms.TextBox tbProductContent;
        private System.Windows.Forms.ComboBox cbxSuppliers;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Panel pnlUrunGuncelle;
        private System.Windows.Forms.Button btnUpdateSave;
        private System.Windows.Forms.Button btnUpdateProductContentPic;
        private System.Windows.Forms.Button btnUpdateBackPic;
        private System.Windows.Forms.Button btnUpdateFrontPic;
        private System.Windows.Forms.TextBox tbUpdateProductContent;
        private System.Windows.Forms.ComboBox cbxUpdateSuppliers;
        private System.Windows.Forms.ComboBox cbxUpdateCategories;
        private System.Windows.Forms.TextBox tbUpdateBarcode;
        private System.Windows.Forms.TextBox tbUpdateProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateBarcodeSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvSearchProduct;
        private System.Windows.Forms.Panel pnlDeleteProduct;
        private System.Windows.Forms.TextBox tbDeleteCategory;
        private System.Windows.Forms.TextBox tbDeleteSupplement;
        private System.Windows.Forms.Label lblDeleteCategory;
        private System.Windows.Forms.Label lblDeleteSupplier;
        private System.Windows.Forms.TextBox tbDeleteBarcode;
        private System.Windows.Forms.TextBox tbDeleteProductContent;
        private System.Windows.Forms.Label lblDeleteBarcode;
        private System.Windows.Forms.Label lblDeleteProductContent;
        private System.Windows.Forms.TextBox tbDeleteAdder;
        private System.Windows.Forms.Label lblDeletyeAdder;
        private System.Windows.Forms.Button btnDeleteDelete;
        private System.Windows.Forms.TextBox tbDeleteProductName;
        private System.Windows.Forms.Label lblDeleteProductName;
        private System.Windows.Forms.Button btnDeleteSearch;
        private System.Windows.Forms.OpenFileDialog FileDialogAddProductContent;
        private System.Windows.Forms.OpenFileDialog FileDialogUpdateProductContent;
        private System.Windows.Forms.OpenFileDialog FileDialogUpdateProductFront;
        private System.Windows.Forms.OpenFileDialog FileDialogUpdateProductBack;
        private System.Windows.Forms.OpenFileDialog FileDialogAddProductFront;
        private System.Windows.Forms.OpenFileDialog FileDialogAddProductBack;
        private System.Windows.Forms.Label lblUrunOnaylamaSayfasi;
        private System.Windows.Forms.Label lblUrunGuncellemeSayfasi;
        private System.Windows.Forms.Label lblUrunSilmeSayfasi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUrunListelemeSayfasi;
        private System.Windows.Forms.Label lblUrunAramaSayfasi;
        private System.Windows.Forms.Button btnApproveOnayla;
    }
}