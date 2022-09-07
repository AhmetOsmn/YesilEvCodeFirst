namespace YesilEvCodeFirst.UIWinForm.Raporlar
{
    partial class Rapor03Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRaporuGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(442, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hangi kullanıcı kaç ürün girmiş";
            // 
            // buttonRaporuGetir
            // 
            this.buttonRaporuGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRaporuGetir.Location = new System.Drawing.Point(503, 104);
            this.buttonRaporuGetir.Name = "buttonRaporuGetir";
            this.buttonRaporuGetir.Size = new System.Drawing.Size(116, 45);
            this.buttonRaporuGetir.TabIndex = 3;
            this.buttonRaporuGetir.Text = "Raporu Getir";
            this.buttonRaporuGetir.UseVisualStyleBackColor = true;
            this.buttonRaporuGetir.Click += new System.EventHandler(this.buttonRaporuGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 385);
            this.dataGridView1.TabIndex = 6;
            // 
            // Rapor03Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRaporuGetir);
            this.Name = "Rapor03Form";
            this.Text = "Rapor3Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRaporuGetir;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}