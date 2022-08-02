
namespace HastaneYonetimSistemi
{
    partial class frmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaKayit));
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskTextTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTexTel = new System.Windows.Forms.MaskedTextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(168, 200);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(225, 33);
            this.txtSifre.TabIndex = 5;
            // 
            // mskTextTC
            // 
            this.mskTextTC.Location = new System.Drawing.Point(168, 104);
            this.mskTextTC.Mask = "00000000000";
            this.mskTextTC.Name = "mskTextTC";
            this.mskTextTC.Size = new System.Drawing.Size(225, 33);
            this.mskTextTC.TabIndex = 3;
            this.mskTextTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(168, 17);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(225, 33);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Soyisim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "İsim :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(168, 65);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(225, 33);
            this.txtSoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cinsiyet :";
            // 
            // maskedTexTel
            // 
            this.maskedTexTel.Location = new System.Drawing.Point(168, 153);
            this.maskedTexTel.Mask = "(999) 000-0000";
            this.maskedTexTel.Name = "maskedTexTel";
            this.maskedTexTel.Size = new System.Drawing.Size(225, 33);
            this.maskedTexTel.TabIndex = 4;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.ItemHeight = 21;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(168, 247);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 29);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.MediumPurple;
            this.btnKayitOl.Location = new System.Drawing.Point(112, 303);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(158, 45);
            this.btnKayitOl.TabIndex = 7;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // frmHastaKayit
            // 
            this.AcceptButton = this.btnKayitOl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(471, 381);
            this.Controls.Add(this.btnKayitOl);
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
            this.MaximizeBox = false;
            this.Name = "frmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.frmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskTextTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTexTel;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Button btnKayitOl;
    }
}