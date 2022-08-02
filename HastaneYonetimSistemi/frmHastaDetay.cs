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
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            txtID.Text = "";
            txtSikayet.Text = "";
            cmbBrans.Text = "";
            comboBoxDoktor.Text = "";
        }
        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBilgiDuzenle blgDuzenle = new frmBilgiDuzenle();
            blgDuzenle.tc = tcNo;
            SqlCommand komut1 = new SqlCommand("select hastaAd,hastaSoyad,hastaTel,hastaSifre,hastaCinsiyet from tblHastalar where hastaTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", tcNo);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                blgDuzenle.ad = dr1[0].ToString();
                blgDuzenle.soyad = dr1[1].ToString();
                blgDuzenle.tel = dr1[2].ToString();
                blgDuzenle.sifre = dr1[3].ToString();
                blgDuzenle.cinsiyet = dr1[4].ToString();

            }
            bgl.baglanti().Close();
            blgDuzenle.Show();
        }

        public string tcNo;


        SqlBaglantisi bgl = new SqlBaglantisi();

        // ad soyad çekme 
        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tcNo;
            SqlCommand komut = new SqlCommand("select hastaAd,hastaSoyad from tblHastalar where hastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // randevu geçmiş
            DataTable dt = new DataTable(); // veri tablosu
            SqlDataAdapter da = new SqlDataAdapter("select * from tblRandevular where hastaTC=" + tcNo, bgl.baglanti());//data gride verileri aktarmak için kullanılan commanddır.
            da.Fill(dt);
            dataGridViewRandevuGecmisi.DataSource = dt;

            //branş'a veri tabanından veri aktarılması
            SqlCommand komut2 = new SqlCommand("select bransAd from tblBranslar ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();
            comboBoxDoktor.Text = " ";

            //doktor'a veri tabanından veri aktarılması:
            SqlCommand komut3 = new SqlCommand("select doktorAd ,doktorSoyad from tblDoktor where doktorBrans=@p2", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p2", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBoxDoktor.Items.Add(dr3[0]+" "+dr3[1]);
            }

            bgl.baglanti().Close();
        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tblRandevular where randevuBrans='" + cmbBrans.Text + "'" + " and randevuDoktor = '" + comboBoxDoktor.Text + "' and randevuDurum = 0", bgl.baglanti());
            da2.Fill(dt2);
            dataGridViewAktifRandevular.DataSource = dt2;
        }

        private void dataGridViewAktifRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewAktifRandevular.SelectedCells[0].RowIndex;
            txtID.Text = dataGridViewAktifRandevular.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand randevuAl = new SqlCommand("update tblRandevular set randevuDurum=1,hastaTC=@p1 ,hastaSikayet=@p2 where randevuID=@p3",bgl.baglanti());
            randevuAl.Parameters.AddWithValue("@p1",tcNo);
            randevuAl.Parameters.AddWithValue("@p2",txtSikayet.Text);
            randevuAl.Parameters.AddWithValue("@p3",txtID.Text);
            randevuAl.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz oluşturuldu.");
            temizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblRandevular where hastaTC ="+tcNo, bgl.baglanti());
            da.Fill(dt);
            dataGridViewRandevuGecmisi.DataSource = dt;
        }
    }
}
