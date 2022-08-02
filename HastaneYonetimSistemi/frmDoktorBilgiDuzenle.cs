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
    public partial class frmDoktorBilgiDuzenle : Form
    {
        public frmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            cmbBrans.Text = "";
            mskTextTC.Text = "";
            txtSifre.Text = "";

        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        public string tc;
        private void frmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            //BRANŞLARI COMBOBOX'A ÇEKME KODU:
            SqlCommand bransGetir = new SqlCommand("select bransAd from tblBranslar ", bgl.baglanti());
            SqlDataReader drBrans = bransGetir.ExecuteReader();
            while (drBrans.Read())
            {
                cmbBrans.Items.Add(drBrans[0]);
            }
            bgl.baglanti().Close();

            //DOKTORUN BİLGİLERİNİ İLGİLİ ALANLARA YAZDIRMA KODU:
            SqlCommand komut = new SqlCommand("select * from tblDoktor where doktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text=dr[1].ToString();
                txtSoyad.Text=dr[2].ToString();
                cmbBrans.Text=dr[3].ToString();
                mskTextTC.Text=dr[4].ToString();
                txtSifre.Text=dr[5].ToString();

            }
            bgl.baglanti().Close();
        }

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update tblDoktor set doktorAd=@p1,doktorSoyad=@p2,doktorBrans=@p3,doktorTC=@p4,doktorSifre=@p5 where doktorTC=@p6", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1",txtAd.Text);
            guncelle.Parameters.AddWithValue("@p2",txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3",cmbBrans.Text);
            guncelle.Parameters.AddWithValue("@p4",mskTextTC.Text);
            guncelle.Parameters.AddWithValue("@p5",txtSifre.Text);
            guncelle.Parameters.AddWithValue("@p6",tc);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz başarılı bir şekilde güncellenmiştir.");
            temizle();
        }
    }
}
