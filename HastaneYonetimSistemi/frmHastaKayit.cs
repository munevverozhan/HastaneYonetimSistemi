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
    public partial class frmHastaKayit : Form
    {
        public frmHastaKayit()
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



        private void frmHastaKayit_Load(object sender, EventArgs e)
        {
            txtAd.Focus();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tblHastalar(hastaAd,hastaSoyad,hastaTC,hastaTel,hastaSifre,hastaCinsiyet) values(@a1,@a2,@a3,@a4,@a5,@a6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@a1", txtAd.Text);
            komut.Parameters.AddWithValue("@a2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@a3",mskTextTC.Text);
            komut.Parameters.AddWithValue("@a4",maskedTexTel.Text);
            komut.Parameters.AddWithValue("@a5",txtSifre.Text);
            komut.Parameters.AddWithValue("@a6",cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız başarılı...");
            temizle();
        }
    }
}
