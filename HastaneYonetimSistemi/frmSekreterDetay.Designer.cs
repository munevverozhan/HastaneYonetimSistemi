
namespace HastaneYonetimSistemi
{
    partial class frmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.randevuDurum = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.maskedTextBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRandevuListe = new System.Windows.Forms.Button();
            this.btnBransPaneli = new System.Windows.Forms.Button();
            this.btnDoktorPaneli = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblAdSoyad.Location = new System.Drawing.Point(150, 87);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(44, 21);
            this.lblAdSoyad.TabIndex = 9;
            this.lblAdSoyad.Text = "null ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(35, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "İsim Soyisim:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblTC.Location = new System.Drawing.Point(150, 40);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(131, 21);
            this.lblTC.TabIndex = 7;
            this.lblTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.btnOlustur);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(22, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.Black;
            this.btnOlustur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOlustur.Location = new System.Drawing.Point(39, 124);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(216, 39);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.randevuDurum);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnGuncelle);
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.maskedTextBoxTC);
            this.groupBox3.Controls.Add(this.comboBoxDoktor);
            this.groupBox3.Controls.Add(this.comboBoxBrans);
            this.groupBox3.Controls.Add(this.maskedTextBoxSaat);
            this.groupBox3.Controls.Add(this.maskedTextBoxTarih);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblID);
            this.groupBox3.Location = new System.Drawing.Point(370, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 484);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // randevuDurum
            // 
            this.randevuDurum.AutoSize = true;
            this.randevuDurum.Location = new System.Drawing.Point(92, 309);
            this.randevuDurum.Name = "randevuDurum";
            this.randevuDurum.Size = new System.Drawing.Size(79, 25);
            this.randevuDurum.TabIndex = 17;
            this.randevuDurum.Text = "Durum";
            this.randevuDurum.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(23, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "DUYURULAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Black;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(23, 384);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(216, 39);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Black;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(23, 340);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(216, 39);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = " KAYDET ";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // maskedTextBoxTC
            // 
            this.maskedTextBoxTC.Location = new System.Drawing.Point(91, 254);
            this.maskedTextBoxTC.Mask = "00000000000";
            this.maskedTextBoxTC.Name = "maskedTextBoxTC";
            this.maskedTextBoxTC.Size = new System.Drawing.Size(155, 33);
            this.maskedTextBoxTC.TabIndex = 12;
            this.maskedTextBoxTC.ValidatingType = typeof(int);
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(91, 209);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(155, 29);
            this.comboBoxDoktor.TabIndex = 11;
//            this.comboBoxDoktor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoktor_SelectedIndexChanged);
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(91, 162);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(155, 29);
            this.comboBoxBrans.TabIndex = 10;
            this.comboBoxBrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrans_SelectedIndexChanged);
            // 
            // maskedTextBoxSaat
            // 
            this.maskedTextBoxSaat.Location = new System.Drawing.Point(92, 112);
            this.maskedTextBoxSaat.Mask = "00:00";
            this.maskedTextBoxSaat.Name = "maskedTextBoxSaat";
            this.maskedTextBoxSaat.Size = new System.Drawing.Size(154, 33);
            this.maskedTextBoxSaat.TabIndex = 9;
            this.maskedTextBoxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxTarih
            // 
            this.maskedTextBoxTarih.Location = new System.Drawing.Point(92, 72);
            this.maskedTextBoxTarih.Mask = "00/00/0000";
            this.maskedTextBoxTarih.Name = "maskedTextBoxTarih";
            this.maskedTextBoxTarih.Size = new System.Drawing.Size(154, 33);
            this.maskedTextBoxTarih.TabIndex = 8;
            this.maskedTextBoxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(91, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 33);
            this.txtID.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "T.C. :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(37, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 21);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(641, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 172);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 140);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(644, 197);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(371, 308);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(365, 276);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox6.Controls.Add(this.btnRandevuListe);
            this.groupBox6.Controls.Add(this.btnBransPaneli);
            this.groupBox6.Controls.Add(this.btnDoktorPaneli);
            this.groupBox6.Location = new System.Drawing.Point(22, 353);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(342, 144);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnRandevuListe
            // 
            this.btnRandevuListe.BackColor = System.Drawing.Color.Snow;
            this.btnRandevuListe.Location = new System.Drawing.Point(61, 96);
            this.btnRandevuListe.Name = "btnRandevuListe";
            this.btnRandevuListe.Size = new System.Drawing.Size(211, 30);
            this.btnRandevuListe.TabIndex = 2;
            this.btnRandevuListe.Text = "RANDEVU LİSTE";
            this.btnRandevuListe.UseVisualStyleBackColor = false;
            this.btnRandevuListe.Click += new System.EventHandler(this.btnRandevuListe_Click);
            // 
            // btnBransPaneli
            // 
            this.btnBransPaneli.BackColor = System.Drawing.Color.Snow;
            this.btnBransPaneli.Location = new System.Drawing.Point(61, 60);
            this.btnBransPaneli.Name = "btnBransPaneli";
            this.btnBransPaneli.Size = new System.Drawing.Size(211, 30);
            this.btnBransPaneli.TabIndex = 1;
            this.btnBransPaneli.Text = "BRANŞ PANELİ";
            this.btnBransPaneli.UseVisualStyleBackColor = false;
            this.btnBransPaneli.Click += new System.EventHandler(this.btnBransPaneli_Click);
            // 
            // btnDoktorPaneli
            // 
            this.btnDoktorPaneli.BackColor = System.Drawing.Color.Snow;
            this.btnDoktorPaneli.Location = new System.Drawing.Point(61, 24);
            this.btnDoktorPaneli.Name = "btnDoktorPaneli";
            this.btnDoktorPaneli.Size = new System.Drawing.Size(211, 30);
            this.btnDoktorPaneli.TabIndex = 0;
            this.btnDoktorPaneli.Text = "DOKTOR PANELİ";
            this.btnDoktorPaneli.UseVisualStyleBackColor = false;
            this.btnDoktorPaneli.Click += new System.EventHandler(this.btnDoktorPaneli_Click);
            // 
            // frmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1024, 509);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.frmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTC;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSaat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTarih;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRandevuListe;
        private System.Windows.Forms.Button btnBransPaneli;
        private System.Windows.Forms.Button btnDoktorPaneli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox randevuDurum;
    }
}