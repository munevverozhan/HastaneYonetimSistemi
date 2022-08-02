
namespace HastaneYonetimSistemi
{
    partial class frmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkKayitOl = new System.Windows.Forms.LinkLabel();
            this.mskTextTC = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre :";
            // 
            // linkKayitOl
            // 
            this.linkKayitOl.AutoSize = true;
            this.linkKayitOl.Location = new System.Drawing.Point(323, 265);
            this.linkKayitOl.Name = "linkKayitOl";
            this.linkKayitOl.Size = new System.Drawing.Size(72, 21);
            this.linkKayitOl.TabIndex = 4;
            this.linkKayitOl.TabStop = true;
            this.linkKayitOl.Text = "Kayıt Ol";
            this.linkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKayitOl_LinkClicked);
            // 
            // mskTextTC
            // 
            this.mskTextTC.Location = new System.Drawing.Point(244, 141);
            this.mskTextTC.Mask = "00000000000";
            this.mskTextTC.Name = "mskTextTC";
            this.mskTextTC.Size = new System.Drawing.Size(225, 33);
            this.mskTextTC.TabIndex = 1;
            this.mskTextTC.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(244, 181);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(225, 33);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.LightPink;
            this.btnGirisYap.Location = new System.Drawing.Point(92, 265);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(173, 41);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // frmHastaGiris
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(606, 355);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskTextTC);
            this.Controls.Add(this.linkKayitOl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmHastaGiris";
            this.Text = "Hasta Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkKayitOl;
        private System.Windows.Forms.MaskedTextBox mskTextTC;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
    }
}