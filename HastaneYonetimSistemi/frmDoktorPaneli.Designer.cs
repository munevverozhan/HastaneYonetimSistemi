
namespace HastaneYonetimSistemi
{
    partial class frmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyisim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Branş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-7, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "T.C. Kimlik No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Şifre :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(174, 38);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(193, 33);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(174, 74);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(193, 33);
            this.txtSoyad.TabIndex = 2;
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Location = new System.Drawing.Point(174, 148);
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(193, 33);
            this.maskedTextBoxTC.TabIndex = 4;
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(174, 113);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(193, 29);
            this.comboBoxBrans.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(174, 187);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(193, 33);
            this.txtSifre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(386, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 298);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEkle.Location = new System.Drawing.Point(137, 226);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 32);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.Location = new System.Drawing.Point(257, 226);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 32);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightYellow;
            this.btnGuncelle.Location = new System.Drawing.Point(137, 277);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(201, 33);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.Snow;
            this.btnListele.Location = new System.Drawing.Point(27, 245);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(83, 55);
            this.btnListele.TabIndex = 17;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(36, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(21, 21);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "0";
            this.lbl.Visible = false;
            // 
            // frmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(963, 322);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.comboBoxBrans);
            this.Controls.Add(this.maskedTextBoxTC);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmDoktorPaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.frmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lbl;
    }
}