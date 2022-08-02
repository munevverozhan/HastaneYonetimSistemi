
namespace HastaneYonetimSistemi
{
    partial class frmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilgiDuzenle));
            this.btnBilgiDuzenle = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.maskedTexTel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskTextTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBilgiDuzenle
            // 
            this.btnBilgiDuzenle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBilgiDuzenle.Location = new System.Drawing.Point(147, 325);
            this.btnBilgiDuzenle.Name = "btnBilgiDuzenle";
            this.btnBilgiDuzenle.Size = new System.Drawing.Size(158, 45);
            this.btnBilgiDuzenle.TabIndex = 32;
            this.btnBilgiDuzenle.Text = "Bilgi Güncelle";
            this.btnBilgiDuzenle.UseVisualStyleBackColor = false;
            this.btnBilgiDuzenle.Click += new System.EventHandler(this.btnBilgiDuzenle_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(171, 266);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 29);
            this.cmbCinsiyet.TabIndex = 31;
            // 
            // maskedTexTel
            // 
            this.maskedTexTel.Location = new System.Drawing.Point(171, 172);
            this.maskedTexTel.Mask = "(999) 000-0000";
            this.maskedTexTel.Name = "maskedTexTel";
            this.maskedTexTel.Size = new System.Drawing.Size(225, 33);
            this.maskedTexTel.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cinsiyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telefon Numarası :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(171, 84);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(225, 33);
            this.txtSoyad.TabIndex = 27;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(171, 36);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(225, 33);
            this.txtAd.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Soyisim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "İsim :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(171, 219);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(225, 33);
            this.txtSifre.TabIndex = 23;
            // 
            // mskTextTC
            // 
            this.mskTextTC.Location = new System.Drawing.Point(171, 123);
            this.mskTextTC.Mask = "00000000000";
            this.mskTextTC.Name = "mskTextTC";
            this.mskTextTC.Size = new System.Drawing.Size(225, 33);
            this.mskTextTC.TabIndex = 22;
            this.mskTextTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // frmBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(448, 422);
            this.Controls.Add(this.btnBilgiDuzenle);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.maskedTexTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskTextTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "frmBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.frmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiDuzenle;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedTexTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskTextTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}