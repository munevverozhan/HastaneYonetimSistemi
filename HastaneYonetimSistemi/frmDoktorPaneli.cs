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
    public partial class frmDoktorPaneli : Form
    {
        public frmDoktorPaneli()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            txtAd.Text = " ";
            txtSoyad.Text = " ";
            txtSifre.Text = " ";
            comboBoxBrans.Text = " ";
            maskedTextBoxTC.Text = " ";
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void frmDoktorPaneli_Load(object sender, EventArgs e)
        {
            // dataGrid'e veri çekilmesi:
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblDoktor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // branşların veritabanından comboBox'a çekilmesi:
            SqlCommand bransListele = new SqlCommand("select bransAd from tblBranslar", bgl.baglanti());
            SqlDataReader drListele = bransListele.ExecuteReader();
            while (drListele.Read())
            {
                comboBoxBrans.Items.Add(drListele[0]);
            }
            bgl.baglanti().Close();

        }
      
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekleDoktor = new SqlCommand("insert into tblDoktor (doktorAd,doktorSoyad,doktorBrans,doktorTC,doktorSifre) values(@a1,@a2,@a3,@a4,@a5) ", bgl.baglanti());
            ekleDoktor.Parameters.AddWithValue("@a1", txtAd.Text);
            ekleDoktor.Parameters.AddWithValue("@a2", txtSoyad.Text);
            ekleDoktor.Parameters.AddWithValue("@a3", comboBoxBrans.Text);
            ekleDoktor.Parameters.AddWithValue("@a4", maskedTextBoxTC.Text);
            ekleDoktor.Parameters.AddWithValue("@a5", txtSifre.Text);
            ekleDoktor.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("doktor başarılı bir şekilde kaydedildi.");
            temizle();

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;           
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBoxTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            lbl.Text = maskedTextBoxTC.Text;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           
            SqlCommand veriSil = new SqlCommand("delete  from tblDoktor where doktorTC=@w1", bgl.baglanti());
            veriSil.Parameters.AddWithValue("@w1",lbl.Text);
            veriSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("doktor verisi başarılı bir şekilde silindi.");
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update tblDoktor set doktorAd=@p1,doktorSoyad=@p2,doktorBrans=@p3,doktorTC=@p4,doktorSifre=@p5 where doktorTC=@q1 ", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1",txtAd.Text);
            guncelle.Parameters.AddWithValue("@p2",txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3",comboBoxBrans.Text);
            guncelle.Parameters.AddWithValue("@p4", maskedTextBoxTC.Text);
            guncelle.Parameters.AddWithValue("@p5",txtSifre.Text);
            guncelle.Parameters.AddWithValue("@q1", lbl.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("verileriniz güncellendi");
            temizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblDoktor",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
