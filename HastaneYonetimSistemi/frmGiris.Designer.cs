
namespace HastaneYonetimSistemi
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnSekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHasta
            // 
            this.btnHasta.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnHasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHasta.BackgroundImage")));
            this.btnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHasta.Location = new System.Drawing.Point(77, 175);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(162, 152);
            this.btnHasta.TabIndex = 0;
            this.btnHasta.UseVisualStyleBackColor = false;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDoktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktor.BackgroundImage")));
            this.btnDoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktor.Location = new System.Drawing.Point(330, 175);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(173, 152);
            this.btnDoktor.TabIndex = 3;
            this.btnDoktor.UseVisualStyleBackColor = false;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // btnSekreter
            // 
            this.btnSekreter.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreter.BackgroundImage")));
            this.btnSekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSekreter.Location = new System.Drawing.Point(626, 175);
            this.btnSekreter.Name = "btnSekreter";
            this.btnSekreter.Size = new System.Drawing.Size(149, 152);
            this.btnSekreter.TabIndex = 4;
            this.btnSekreter.UseVisualStyleBackColor = false;
            this.btnSekreter.Click += new System.EventHandler(this.btnSekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "DOKTOR GİRİŞ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "HASTA GİRİŞ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "SEKRETER GİRİŞ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(190, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(506, 61);
            this.label4.TabIndex = 9;
            this.label4.Text = "KALP ATIŞI HASTANESİ";
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(864, 392);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreter);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnHasta);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmGiris";
            this.Text = "Kalp Atışı Hastanesi Giriş";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonHighlight;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnSekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

