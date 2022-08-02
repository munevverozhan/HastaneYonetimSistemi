
namespace HastaneYonetimSistemi
{
    partial class frmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorBilgiDuzenle));
            this.btnBilgiDuzenle = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskTextTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBilgiDuzenle
            // 
            this.btnBilgiDuzenle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBilgiDuzenle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBilgiDuzenle.Location = new System.Drawing.Point(143, 270);
            this.btnBilgiDuzenle.Name = "btnBilgiDuzenle";
            this.btnBilgiDuzenle.Size = new System.Drawing.Size(158, 45);
            this.btnBilgiDuzenle.TabIndex = 45;
            this.btnBilgiDuzenle.Text = "Bilgi Güncelle";
            this.btnBilgiDuzenle.UseVisualStyleBackColor = false;
            this.btnBilgiDuzenle.Click += new System.EventHandler(this.btnBilgiDuzenle_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(178, 71);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(225, 33);
            this.txtSoyad.TabIndex = 40;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(178, 26);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(225, 33);
            this.txtAd.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Soyisim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "İsim :";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(178, 208);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(225, 33);
            this.txtSifre.TabIndex = 36;
            // 
            // mskTextTC
            // 
            this.mskTextTC.Location = new System.Drawing.Point(178, 161);
            this.mskTextTC.Mask = "00000000000";
            this.mskTextTC.Name = "mskTextTC";
            this.mskTextTC.Size = new System.Drawing.Size(225, 33);
            this.mskTextTC.TabIndex = 35;
            this.mskTextTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 46;
            this.label5.Text = "Branş :";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(178, 116);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(219, 29);
            this.cmbBrans.TabIndex = 47;
            // 
            // frmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(465, 362);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBilgiDuzenle);
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
            this.Name = "frmDoktorBilgiDuzenle";
            this.Text = "Doktor Bilgi Duzenle";
            this.Load += new System.EventHandler(this.frmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiDuzenle;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskTextTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBrans;
    }
}