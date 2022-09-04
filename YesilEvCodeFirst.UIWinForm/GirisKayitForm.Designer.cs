namespace YesilEvCodeFirst.UIWinForm
{
    partial class SignInSignUpForm
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
            this.btnGrpBoxSignUp = new System.Windows.Forms.Button();
            this.btnGrpBoxSignIn = new System.Windows.Forms.Button();
            this.GrpBoxSignUp = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.GrpBoxSignIn = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtSignInPassword = new System.Windows.Forms.TextBox();
            this.lblSignInPassword = new System.Windows.Forms.Label();
            this.txtSignInEmail = new System.Windows.Forms.TextBox();
            this.lblSignInEmail = new System.Windows.Forms.Label();
            this.GrpBoxSignUp.SuspendLayout();
            this.GrpBoxSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGroupBoxKayitOl
            // 
            this.btnGrpBoxSignUp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGrpBoxSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrpBoxSignUp.FlatAppearance.BorderSize = 0;
            this.btnGrpBoxSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrpBoxSignUp.ForeColor = System.Drawing.Color.White;
            this.btnGrpBoxSignUp.Location = new System.Drawing.Point(12, 42);
            this.btnGrpBoxSignUp.Name = "btnGroupBoxKayitOl";
            this.btnGrpBoxSignUp.Size = new System.Drawing.Size(215, 37);
            this.btnGrpBoxSignUp.TabIndex = 0;
            this.btnGrpBoxSignUp.Text = "Kayıt Ol";
            this.btnGrpBoxSignUp.UseVisualStyleBackColor = false;
            this.btnGrpBoxSignUp.Click += new System.EventHandler(this.OpenSignUpDetails);
            // 
            // btnGroupBoxGirisYap
            // 
            this.btnGrpBoxSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btnGrpBoxSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrpBoxSignIn.FlatAppearance.BorderSize = 0;
            this.btnGrpBoxSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrpBoxSignIn.ForeColor = System.Drawing.Color.White;
            this.btnGrpBoxSignIn.Location = new System.Drawing.Point(229, 42);
            this.btnGrpBoxSignIn.Name = "btnGroupBoxGirisYap";
            this.btnGrpBoxSignIn.Size = new System.Drawing.Size(215, 37);
            this.btnGrpBoxSignIn.TabIndex = 0;
            this.btnGrpBoxSignIn.Text = "Giriş Yap";
            this.btnGrpBoxSignIn.UseVisualStyleBackColor = false;
            this.btnGrpBoxSignIn.Click += new System.EventHandler(this.OpenSignInDetails);
            // 
            // GroupBoxKayitOl
            // 
            this.GrpBoxSignUp.Controls.Add(this.btnSignUp);
            this.GrpBoxSignUp.Controls.Add(this.txtFirstName);
            this.GrpBoxSignUp.Controls.Add(this.txtLastName);
            this.GrpBoxSignUp.Controls.Add(this.txtPassword);
            this.GrpBoxSignUp.Controls.Add(this.txtEmail);
            this.GrpBoxSignUp.Controls.Add(this.lblPassword);
            this.GrpBoxSignUp.Controls.Add(this.lblEmail);
            this.GrpBoxSignUp.Controls.Add(this.lblLastName);
            this.GrpBoxSignUp.Controls.Add(this.lblFirstName);
            this.GrpBoxSignUp.ForeColor = System.Drawing.Color.White;
            this.GrpBoxSignUp.Location = new System.Drawing.Point(12, 102);
            this.GrpBoxSignUp.Name = "GroupBoxKayitOl";
            this.GrpBoxSignUp.Size = new System.Drawing.Size(432, 299);
            this.GrpBoxSignUp.TabIndex = 1;
            this.GrpBoxSignUp.TabStop = false;
            this.GrpBoxSignUp.Text = "Ücretsiz Kayıt Ol";
            this.GrpBoxSignUp.Visible = false;
            // 
            // btnKayitOl
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(69, 230);
            this.btnSignUp.Name = "btnKayitOl";
            this.btnSignUp.Size = new System.Drawing.Size(289, 41);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Kayıt Ol";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtIsim
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(20, 54);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtIsim";
            this.txtFirstName.Size = new System.Drawing.Size(179, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtSoyisim
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(230, 53);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtSoyisim";
            this.txtLastName.Size = new System.Drawing.Size(179, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(22, 181);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtSifre";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(387, 26);
            this.txtPassword.TabIndex = 4;
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
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(19, 165);
            this.lblPassword.Name = "lblSifre";
            this.lblPassword.Size = new System.Drawing.Size(28, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre";
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
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(230, 38);
            this.lblLastName.Name = "lblSoyisim";
            this.lblLastName.Size = new System.Drawing.Size(42, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Soyisim";
            // 
            // lblIsim
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(19, 38);
            this.lblFirstName.Name = "lblIsim";
            this.lblFirstName.Size = new System.Drawing.Size(25, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "İsim";
            // 
            // GroupBoxGirisYap
            // 
            this.GrpBoxSignIn.Controls.Add(this.btnSignIn);
            this.GrpBoxSignIn.Controls.Add(this.txtSignInPassword);
            this.GrpBoxSignIn.Controls.Add(this.lblSignInPassword);
            this.GrpBoxSignIn.Controls.Add(this.txtSignInEmail);
            this.GrpBoxSignIn.Controls.Add(this.lblSignInEmail);
            this.GrpBoxSignIn.ForeColor = System.Drawing.Color.White;
            this.GrpBoxSignIn.Location = new System.Drawing.Point(12, 102);
            this.GrpBoxSignIn.Name = "GroupBoxGirisYap";
            this.GrpBoxSignIn.Size = new System.Drawing.Size(432, 277);
            this.GrpBoxSignIn.TabIndex = 2;
            this.GrpBoxSignIn.TabStop = false;
            this.GrpBoxSignIn.Text = "Giriş Yap";
            // 
            // btnGirisYap
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(69, 197);
            this.btnSignIn.Name = "btnGirisYap";
            this.btnSignIn.Size = new System.Drawing.Size(289, 41);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Giriş Yap";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtGirisYapSifre
            // 
            this.txtSignInPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSignInPassword.ForeColor = System.Drawing.Color.White;
            this.txtSignInPassword.Location = new System.Drawing.Point(17, 135);
            this.txtSignInPassword.Name = "txtGirisYapSifre";
            this.txtSignInPassword.PasswordChar = '*';
            this.txtSignInPassword.Size = new System.Drawing.Size(387, 20);
            this.txtSignInPassword.TabIndex = 2;
            this.txtSignInPassword.Text = "mert555";
            // 
            // lblGirisYapSifre
            // 
            this.lblSignInPassword.AutoSize = true;
            this.lblSignInPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblSignInPassword.ForeColor = System.Drawing.Color.White;
            this.lblSignInPassword.Location = new System.Drawing.Point(17, 119);
            this.lblSignInPassword.Name = "lblGirisYapSifre";
            this.lblSignInPassword.Size = new System.Drawing.Size(28, 13);
            this.lblSignInPassword.TabIndex = 1;
            this.lblSignInPassword.Text = "Şifre";
            // 
            // txtGirisYapEmail
            // 
            this.txtSignInEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSignInEmail.ForeColor = System.Drawing.Color.White;
            this.txtSignInEmail.Location = new System.Drawing.Point(17, 83);
            this.txtSignInEmail.Name = "txtGirisYapEmail";
            this.txtSignInEmail.Size = new System.Drawing.Size(387, 20);
            this.txtSignInEmail.TabIndex = 1;
            this.txtSignInEmail.Text = "mertdalkiran@gmail.com";
            // 
            // lblGirisYapEmail
            // 
            this.lblSignInEmail.AutoSize = true;
            this.lblSignInEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblSignInEmail.ForeColor = System.Drawing.Color.White;
            this.lblSignInEmail.Location = new System.Drawing.Point(17, 67);
            this.lblSignInEmail.Name = "lblGirisYapEmail";
            this.lblSignInEmail.Size = new System.Drawing.Size(32, 13);
            this.lblSignInEmail.TabIndex = 1;
            this.lblSignInEmail.Text = "Email";
            // 
            // GirisKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(456, 475);
            this.Controls.Add(this.btnGrpBoxSignIn);
            this.Controls.Add(this.btnGrpBoxSignUp);
            this.Controls.Add(this.GrpBoxSignIn);
            this.Controls.Add(this.GrpBoxSignUp);
            this.Name = "GirisKayitForm";
            this.Text = "Form1";
            this.GrpBoxSignUp.ResumeLayout(false);
            this.GrpBoxSignUp.PerformLayout();
            this.GrpBoxSignIn.ResumeLayout(false);
            this.GrpBoxSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrpBoxSignUp;
        private System.Windows.Forms.Button btnGrpBoxSignIn;
        private System.Windows.Forms.GroupBox GrpBoxSignUp;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox GrpBoxSignIn;
        private System.Windows.Forms.Label lblSignInEmail;
        private System.Windows.Forms.TextBox txtSignInEmail;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtSignInPassword;
        private System.Windows.Forms.Label lblSignInPassword;
    }
}

