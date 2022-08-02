using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneYonetimSistemi
{
    public partial class frmBilgiDuzenle : Form
    {
        public frmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public void temizle()
        {
            txtAd.Text = " ";
            txtSoyad.Text = " ";
            txtSifre.Text = " ";
            cmbCinsiyet.Text = " ";
            mskTextTC.Text = " ";
            maskedTexTel.Text = " ";

        }

        public string ad;
        public string soyad;
        public string sifre;
        public string tc;
        public string cinsiyet;
        public string tel;


        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {

            mskTextTC.Text = tc;
            SqlCommand komut = new SqlCommand("update tblHastalar set hastaAd=@p1,hastaSoyad=@p2,hastaTel=@p4,hastaSifre=@p5,hastaCinsiyet=@p6 where hastaTC=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", maskedTexTel.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p3", tc);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz başarılı bir şekilde güncellendi.");

            temizle();

        }

        private void frmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtSifre.Text = sifre;
            cmbCinsiyet.Text = cinsiyet;
            mskTextTC.Text = tc;
            maskedTexTel.Text = tel;

        }
    }
}
