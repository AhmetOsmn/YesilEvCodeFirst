namespace YesilEvCodeFirst.UIWinForm
{
    partial class GirisKayitForm
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
            this.btnGroupBoxKayitOl = new System.Windows.Forms.Button();
            this.btnGroupBoxGirisYap = new System.Windows.Forms.Button();
            this.GroupBoxKayitOl = new System.Windows.Forms.GroupBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.GroupBoxGirisYap = new System.Windows.Forms.GroupBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtGirisYapSifre = new System.Windows.Forms.TextBox();
            this.lblGirisYapSifre = new System.Windows.Forms.Label();
            this.txtGirisYapEmail = new System.Windows.Forms.TextBox();
            this.lblGirisYapEmail = new System.Windows.Forms.Label();
            this.GroupBoxKayitOl.SuspendLayout();
            this.GroupBoxGirisYap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGroupBoxKayitOl
            // 
            this.btnGroupBoxKayitOl.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGroupBoxKayitOl.FlatAppearance.BorderSize = 0;
            this.btnGroupBoxKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupBoxKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnGroupBoxKayitOl.Location = new System.Drawing.Point(12, 42);
            this.btnGroupBoxKayitOl.Name = "btnGroupBoxKayitOl";
            this.btnGroupBoxKayitOl.Size = new System.Drawing.Size(215, 37);
            this.btnGroupBoxKayitOl.TabIndex = 0;
            this.btnGroupBoxKayitOl.Text = "Kayıt Ol";
            this.btnGroupBoxKayitOl.UseVisualStyleBackColor = false;
            this.btnGroupBoxKayitOl.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGroupBoxGirisYap
            // 
            this.btnGroupBoxGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btnGroupBoxGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGroupBoxGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupBoxGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGroupBoxGirisYap.Location = new System.Drawing.Point(229, 42);
            this.btnGroupBoxGirisYap.Name = "btnGroupBoxGirisYap";
            this.btnGroupBoxGirisYap.Size = new System.Drawing.Size(215, 37);
            this.btnGroupBoxGirisYap.TabIndex = 0;
            this.btnGroupBoxGirisYap.Text = "Giriş Yap";
            this.btnGroupBoxGirisYap.UseVisualStyleBackColor = false;
            this.btnGroupBoxGirisYap.Click += new System.EventHandler(this.button2_Click);
            // 
            // GroupBoxKayitOl
            // 
            this.GroupBoxKayitOl.Controls.Add(this.btnKayitOl);
            this.GroupBoxKayitOl.Controls.Add(this.txtIsim);
            this.GroupBoxKayitOl.Controls.Add(this.txtSoyisim);
            this.GroupBoxKayitOl.Controls.Add(this.txtSifre);
            this.GroupBoxKayitOl.Controls.Add(this.txtEmail);
            this.GroupBoxKayitOl.Controls.Add(this.lblSifre);
            this.GroupBoxKayitOl.Controls.Add(this.lblEmail);
            this.GroupBoxKayitOl.Controls.Add(this.lblSoyisim);
            this.GroupBoxKayitOl.Controls.Add(this.lblIsim);
            this.GroupBoxKayitOl.ForeColor = System.Drawing.Color.White;
            this.GroupBoxKayitOl.Location = new System.Drawing.Point(12, 102);
            this.GroupBoxKayitOl.Name = "GroupBoxKayitOl";
            this.GroupBoxKayitOl.Size = new System.Drawing.Size(432, 299);
            this.GroupBoxKayitOl.TabIndex = 1;
            this.GroupBoxKayitOl.TabStop = false;
            this.GroupBoxKayitOl.Text = "Ücretsiz Kayıt Ol";
            this.GroupBoxKayitOl.Visible = false;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnKayitOl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnKayitOl.FlatAppearance.BorderSize = 0;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(69, 230);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(289, 41);
            this.btnKayitOl.TabIndex = 5;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtIsim.ForeColor = System.Drawing.Color.White;
            this.txtIsim.Location = new System.Drawing.Point(20, 54);
            this.txtIsim.Multiline = true;
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(179, 26);
            this.txtIsim.TabIndex = 1;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSoyisim.ForeColor = System.Drawing.Color.White;
            this.txtSoyisim.Location = new System.Drawing.Point(230, 53);
            this.txtSoyisim.Multiline = true;
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(179, 26);
            this.txtSoyisim.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.Location = new System.Drawing.Point(22, 181);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(387, 26);
            this.txtSifre.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(22, 116);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(387, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblSifre.ForeColor = System.Drawing.Color.White;
            this.lblSifre.Location = new System.Drawing.Point(19, 165);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 13);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(19, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblSoyisim.ForeColor = System.Drawing.Color.White;
            this.lblSoyisim.Location = new System.Drawing.Point(230, 38);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(42, 13);
            this.lblSoyisim.TabIndex = 0;
            this.lblSoyisim.Text = "Soyisim";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblIsim.ForeColor = System.Drawing.Color.White;
            this.lblIsim.Location = new System.Drawing.Point(19, 38);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(25, 13);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "İsim";
            // 
            // GroupBoxGirisYap
            // 
            this.GroupBoxGirisYap.Controls.Add(this.btnGirisYap);
            this.GroupBoxGirisYap.Controls.Add(this.txtGirisYapSifre);
            this.GroupBoxGirisYap.Controls.Add(this.lblGirisYapSifre);
            this.GroupBoxGirisYap.Controls.Add(this.txtGirisYapEmail);
            this.GroupBoxGirisYap.Controls.Add(this.lblGirisYapEmail);
            this.GroupBoxGirisYap.ForeColor = System.Drawing.Color.White;
            this.GroupBoxGirisYap.Location = new System.Drawing.Point(12, 102);
            this.GroupBoxGirisYap.Name = "GroupBoxGirisYap";
            this.GroupBoxGirisYap.Size = new System.Drawing.Size(432, 277);
            this.GroupBoxGirisYap.TabIndex = 2;
            this.GroupBoxGirisYap.TabStop = false;
            this.GroupBoxGirisYap.Text = "Giriş Yap";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.Location = new System.Drawing.Point(69, 197);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(289, 41);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // txtGirisYapSifre
            // 
            this.txtGirisYapSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtGirisYapSifre.ForeColor = System.Drawing.Color.White;
            this.txtGirisYapSifre.Location = new System.Drawing.Point(17, 135);
            this.txtGirisYapSifre.Name = "txtGirisYapSifre";
            this.txtGirisYapSifre.PasswordChar = '*';
            this.txtGirisYapSifre.Size = new System.Drawing.Size(387, 20);
            this.txtGirisYapSifre.TabIndex = 2;
            this.txtGirisYapSifre.Text = "sarp555";
            // 
            // lblGirisYapSifre
            // 
            this.lblGirisYapSifre.AutoSize = true;
            this.lblGirisYapSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblGirisYapSifre.ForeColor = System.Drawing.Color.White;
            this.lblGirisYapSifre.Location = new System.Drawing.Point(17, 119);
            this.lblGirisYapSifre.Name = "lblGirisYapSifre";
            this.lblGirisYapSifre.Size = new System.Drawing.Size(28, 13);
            this.lblGirisYapSifre.TabIndex = 1;
            this.lblGirisYapSifre.Text = "Şifre";
            // 
            // txtGirisYapEmail
            // 
            this.txtGirisYapEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtGirisYapEmail.ForeColor = System.Drawing.Color.White;
            this.txtGirisYapEmail.Location = new System.Drawing.Point(17, 83);
            this.txtGirisYapEmail.Name = "txtGirisYapEmail";
            this.txtGirisYapEmail.Size = new System.Drawing.Size(387, 20);
            this.txtGirisYapEmail.TabIndex = 1;
            this.txtGirisYapEmail.Text = "sarp@gmail.com";
            // 
            // lblGirisYapEmail
            // 
            this.lblGirisYapEmail.AutoSize = true;
            this.lblGirisYapEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblGirisYapEmail.ForeColor = System.Drawing.Color.White;
            this.lblGirisYapEmail.Location = new System.Drawing.Point(17, 67);
            this.lblGirisYapEmail.Name = "lblGirisYapEmail";
            this.lblGirisYapEmail.Size = new System.Drawing.Size(32, 13);
            this.lblGirisYapEmail.TabIndex = 1;
            this.lblGirisYapEmail.Text = "Email";
            // 
            // GirisKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(456, 475);
            this.Controls.Add(this.btnGroupBoxGirisYap);
            this.Controls.Add(this.btnGroupBoxKayitOl);
            this.Controls.Add(this.GroupBoxKayitOl);
            this.Controls.Add(this.GroupBoxGirisYap);
            this.Name = "GirisKayitForm";
            this.Text = "Form1";
            this.GroupBoxKayitOl.ResumeLayout(false);
            this.GroupBoxKayitOl.PerformLayout();
            this.GroupBoxGirisYap.ResumeLayout(false);
            this.GroupBoxGirisYap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGroupBoxKayitOl;
        private System.Windows.Forms.Button btnGroupBoxGirisYap;
        private System.Windows.Forms.GroupBox GroupBoxKayitOl;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox GroupBoxGirisYap;
        private System.Windows.Forms.Label lblGirisYapEmail;
        private System.Windows.Forms.TextBox txtGirisYapEmail;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtGirisYapSifre;
        private System.Windows.Forms.Label lblGirisYapSifre;
    }
}

