
namespace HastaneYonetimSistemi
{
    partial class frmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkBilgiDuzenle = new System.Windows.Forms.LinkLabel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSikayet = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRandevuGecmisi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAktifRandevular = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevuGecmisi)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktifRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.lnkBilgiDuzenle);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // lnkBilgiDuzenle
            // 
            this.lnkBilgiDuzenle.AutoSize = true;
            this.lnkBilgiDuzenle.Location = new System.Drawing.Point(265, 125);
            this.lnkBilgiDuzenle.Name = "lnkBilgiDuzenle";
            this.lnkBilgiDuzenle.Size = new System.Drawing.Size(146, 21);
            this.lnkBilgiDuzenle.TabIndex = 11;
            this.lnkBilgiDuzenle.TabStop = true;
            this.lnkBilgiDuzenle.Text = "Bilgilerimi Düzenle";
            this.lnkBilgiDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBilgiDuzenle_LinkClicked);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(172, 90);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(44, 21);
            this.lblAdSoyad.TabIndex = 5;
            this.lblAdSoyad.Text = "null ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "İsim Soyisim:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(172, 43);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(131, 21);
            this.lblTC.TabIndex = 3;
            this.lblTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnRandevuAl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSikayet);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxDoktor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbBrans);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 321);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(121, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(262, 33);
            this.txtID.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Randevu ID :";
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRandevuAl.Location = new System.Drawing.Point(166, 268);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(177, 42);
            this.btnRandevuAl.TabIndex = 10;
            this.btnRandevuAl.Text = "RANDEVU AL";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şikayet :";
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(121, 173);
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(262, 92);
            this.txtSikayet.TabIndex = 8;
            this.txtSikayet.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor :";
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(121, 125);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(262, 29);
            this.comboBoxDoktor.TabIndex = 6;
            this.comboBoxDoktor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoktor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Branş :";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(121, 74);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(262, 29);
            this.cmbBrans.TabIndex = 0;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewRandevuGecmisi);
            this.groupBox3.Location = new System.Drawing.Point(470, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 231);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridViewRandevuGecmisi
            // 
            this.dataGridViewRandevuGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRandevuGecmisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRandevuGecmisi.Location = new System.Drawing.Point(3, 29);
            this.dataGridViewRandevuGecmisi.Name = "dataGridViewRandevuGecmisi";
            this.dataGridViewRandevuGecmisi.Size = new System.Drawing.Size(467, 199);
            this.dataGridViewRandevuGecmisi.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewAktifRandevular);
            this.groupBox4.Location = new System.Drawing.Point(470, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 249);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridViewAktifRandevular
            // 
            this.dataGridViewAktifRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAktifRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAktifRandevular.Location = new System.Drawing.Point(3, 29);
            this.dataGridViewAktifRandevular.Name = "dataGridViewAktifRandevular";
            this.dataGridViewAktifRandevular.Size = new System.Drawing.Size(467, 217);
            this.dataGridViewAktifRandevular.TabIndex = 0;
            this.dataGridViewAktifRandevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAktifRandevular_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.MistyRose;
            this.btnListele.Location = new System.Drawing.Point(10, 255);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(106, 55);
            this.btnListele.TabIndex = 13;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // frmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(955, 511);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmHastaDetay";
            this.Text = "HastaDetay";
            this.Load += new System.EventHandler(this.frmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevuGecmisi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktifRandevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtSikayet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewRandevuGecmisi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewAktifRandevular;
        private System.Windows.Forms.LinkLabel lnkBilgiDuzenle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnListele;
    }
}