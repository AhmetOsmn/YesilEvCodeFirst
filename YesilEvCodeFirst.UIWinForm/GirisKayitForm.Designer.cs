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
            // btnGrpBoxSignUp
            // 
            this.btnGrpBoxSignUp.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGrpBoxSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrpBoxSignUp.FlatAppearance.BorderSize = 0;
            this.btnGrpBoxSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrpBoxSignUp.ForeColor = System.Drawing.Color.White;
            this.btnGrpBoxSignUp.Location = new System.Drawing.Point(16, 52);
            this.btnGrpBoxSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrpBoxSignUp.Name = "btnGrpBoxSignUp";
            this.btnGrpBoxSignUp.Size = new System.Drawing.Size(287, 46);
            this.btnGrpBoxSignUp.TabIndex = 0;
            this.btnGrpBoxSignUp.Text = "Kayıt Ol";
            this.btnGrpBoxSignUp.UseVisualStyleBackColor = false;
            this.btnGrpBoxSignUp.Click += new System.EventHandler(this.OpenSignUpDetails);
            // 
            // btnGrpBoxSignIn
            // 
            this.btnGrpBoxSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btnGrpBoxSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrpBoxSignIn.FlatAppearance.BorderSize = 0;
            this.btnGrpBoxSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrpBoxSignIn.ForeColor = System.Drawing.Color.White;
            this.btnGrpBoxSignIn.Location = new System.Drawing.Point(305, 52);
            this.btnGrpBoxSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrpBoxSignIn.Name = "btnGrpBoxSignIn";
            this.btnGrpBoxSignIn.Size = new System.Drawing.Size(287, 46);
            this.btnGrpBoxSignIn.TabIndex = 0;
            this.btnGrpBoxSignIn.Text = "Giriş Yap";
            this.btnGrpBoxSignIn.UseVisualStyleBackColor = false;
            this.btnGrpBoxSignIn.Click += new System.EventHandler(this.OpenSignInDetails);
            // 
            // GrpBoxSignUp
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
            this.GrpBoxSignUp.Location = new System.Drawing.Point(16, 126);
            this.GrpBoxSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBoxSignUp.Name = "GrpBoxSignUp";
            this.GrpBoxSignUp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBoxSignUp.Size = new System.Drawing.Size(576, 368);
            this.GrpBoxSignUp.TabIndex = 1;
            this.GrpBoxSignUp.TabStop = false;
            this.GrpBoxSignUp.Text = "Ücretsiz Kayıt Ol";
            this.GrpBoxSignUp.Visible = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(92, 283);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(385, 50);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Kayıt Ol";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(27, 66);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(237, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(307, 65);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(237, 31);
            this.txtLastName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(29, 223);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(515, 31);
            this.txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(29, 143);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(515, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(25, 203);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(34, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(25, 123);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(307, 47);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 16);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Soyisim";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(25, 47);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(31, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "İsim";
            // 
            // GrpBoxSignIn
            // 
            this.GrpBoxSignIn.Controls.Add(this.btnSignIn);
            this.GrpBoxSignIn.Controls.Add(this.txtSignInPassword);
            this.GrpBoxSignIn.Controls.Add(this.lblSignInPassword);
            this.GrpBoxSignIn.Controls.Add(this.txtSignInEmail);
            this.GrpBoxSignIn.Controls.Add(this.lblSignInEmail);
            this.GrpBoxSignIn.ForeColor = System.Drawing.Color.White;
            this.GrpBoxSignIn.Location = new System.Drawing.Point(16, 126);
            this.GrpBoxSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBoxSignIn.Name = "GrpBoxSignIn";
            this.GrpBoxSignIn.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpBoxSignIn.Size = new System.Drawing.Size(576, 341);
            this.GrpBoxSignIn.TabIndex = 2;
            this.GrpBoxSignIn.TabStop = false;
            this.GrpBoxSignIn.Text = "Giriş Yap";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(92, 242);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(385, 50);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Giriş Yap";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtSignInPassword
            // 
            this.txtSignInPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSignInPassword.ForeColor = System.Drawing.Color.White;
            this.txtSignInPassword.Location = new System.Drawing.Point(23, 166);
            this.txtSignInPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSignInPassword.Name = "txtSignInPassword";
            this.txtSignInPassword.PasswordChar = '*';
            this.txtSignInPassword.Size = new System.Drawing.Size(515, 22);
            this.txtSignInPassword.TabIndex = 2;
            this.txtSignInPassword.Text = "12345";
            // 
            // lblSignInPassword
            // 
            this.lblSignInPassword.AutoSize = true;
            this.lblSignInPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblSignInPassword.ForeColor = System.Drawing.Color.White;
            this.lblSignInPassword.Location = new System.Drawing.Point(23, 146);
            this.lblSignInPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignInPassword.Name = "lblSignInPassword";
            this.lblSignInPassword.Size = new System.Drawing.Size(34, 16);
            this.lblSignInPassword.TabIndex = 1;
            this.lblSignInPassword.Text = "Şifre";
            // 
            // txtSignInEmail
            // 
            this.txtSignInEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.txtSignInEmail.ForeColor = System.Drawing.Color.White;
            this.txtSignInEmail.Location = new System.Drawing.Point(23, 102);
            this.txtSignInEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSignInEmail.Name = "txtSignInEmail";
            this.txtSignInEmail.Size = new System.Drawing.Size(515, 22);
            this.txtSignInEmail.TabIndex = 1;
            this.txtSignInEmail.Text = "sarp@gmail.com";
            // 
            // lblSignInEmail
            // 
            this.lblSignInEmail.AutoSize = true;
            this.lblSignInEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.lblSignInEmail.ForeColor = System.Drawing.Color.White;
            this.lblSignInEmail.Location = new System.Drawing.Point(23, 82);
            this.lblSignInEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignInEmail.Name = "lblSignInEmail";
            this.lblSignInEmail.Size = new System.Drawing.Size(41, 16);
            this.lblSignInEmail.TabIndex = 1;
            this.lblSignInEmail.Text = "Email";
            // 
            // SignInSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(608, 585);
            this.Controls.Add(this.btnGrpBoxSignUp);
            this.Controls.Add(this.btnGrpBoxSignIn);
            this.Controls.Add(this.GrpBoxSignIn);
            this.Controls.Add(this.GrpBoxSignUp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignInSignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Green Home";
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

