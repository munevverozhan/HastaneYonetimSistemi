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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            comboBoxBrans.Text = " ";
            comboBoxDoktor.Text = " ";
            maskedTextBoxSaat.Text = " ";
            maskedTextBoxTarih.Text = " ";
            maskedTextBoxTC.Text = " ";
        }

        public string cbbrans;
        public string cbdoktor;
        public string saat;
        public string tarih;
        public string id;
        public string TC;
        


        SqlBaglantisi bgl = new SqlBaglantisi();

        public string tc;
        public string adSoyad;
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
 
            lblTC.Text = tc;
            lblAdSoyad.Text = adSoyad;

            //BRANSLARI DATA GRID'E CEKME:

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblBranslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Doktorlar Tablosuna veritabanından veri çekme: 
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (doktorAd +' '+doktorSoyad) as AdSoyad,doktorBrans from tblDoktor", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //branşları comboBox'a çekme
            SqlCommand listeleBrans = new SqlCommand("select bransAd from tblBranslar", bgl.baglanti());
            SqlDataReader dr = listeleBrans.ExecuteReader();
            while (dr.Read())
            {
                comboBoxBrans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();


            // güncelleme butonu için frmRandevuListesi formundan gelen verilerin ilgili yerleri doldurması:
            txtID.Text = id;
            comboBoxBrans.Text = cbbrans;
            comboBoxDoktor.Text = cbdoktor;
            maskedTextBoxSaat.Text = saat;
            maskedTextBoxTarih.Text = tarih;
            maskedTextBoxTC.Text = TC;
            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            SqlCommand ekle = new SqlCommand("insert into tblRandevular(randevuTarih,randevuSaat,randevuBrans,randevuDoktor) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", maskedTextBoxTarih.Text);
            ekle.Parameters.AddWithValue("@p2", maskedTextBoxSaat.Text);
            ekle.Parameters.AddWithValue("@p3", comboBoxBrans.Text);
            ekle.Parameters.AddWithValue("@p4", comboBoxDoktor.Text);
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevu başarıyla oluşturuldu.");
            temizle();

        }


        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();
            comboBoxDoktor.Text = " ";
            //doktorları comboBox'a çekme
            SqlCommand listeleDoktor = new SqlCommand("select doktorAd ,doktorSoyad  from tblDoktor where doktorBrans = @p7", bgl.baglanti());
            listeleDoktor.Parameters.AddWithValue("@p7", comboBoxBrans.Text);
            SqlDataReader dr1 = listeleDoktor.ExecuteReader();
            while (dr1.Read())
            {
                comboBoxDoktor.Items.Add(dr1[0]+" "+dr1[1]);
            }
            bgl.baglanti().Close();


        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand duyuruOlustur = new SqlCommand("insert into tblDuyuru(duyuru) values(@d1)", bgl.baglanti());
            duyuruOlustur.Parameters.AddWithValue("@d1", richTextBox1.Text);
            duyuruOlustur.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("duyuru oluşturuldu.");
            richTextBox1.Text = " ";
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            frmDoktorPaneli frmDoktorPaneli = new frmDoktorPaneli();
            frmDoktorPaneli.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            frmBrans frmbrans = new frmBrans();
            frmbrans.Show();
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            frmRandevuListesi randevular = new frmRandevuListesi();
           
            randevular.Show();
          
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            SqlCommand guncelleRandevu = new SqlCommand("update tblRandevular set randevuTarih=@g1,randevuSaat=@g2,randevuBrans=@g3,randevuDoktor=@g4,hastaTC=@g5 where randevuID=@g6",bgl.baglanti());
            guncelleRandevu.Parameters.AddWithValue("@g1",maskedTextBoxTarih.Text);
            guncelleRandevu.Parameters.AddWithValue("@g2",maskedTextBoxSaat.Text);
            guncelleRandevu.Parameters.AddWithValue("@g3",comboBoxBrans.Text);
            guncelleRandevu.Parameters.AddWithValue("@g4",comboBoxDoktor.Text);
            guncelleRandevu.Parameters.AddWithValue("@g5",maskedTextBoxTC.Text);
            guncelleRandevu.Parameters.AddWithValue("@g6",id);
            guncelleRandevu.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("randevunuz başarılı bir şekilde güncellenmiştir.");
            temizle();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDuyurular duyuru = new frmDuyurular();
            duyuru.Show();
        }
    }
}
