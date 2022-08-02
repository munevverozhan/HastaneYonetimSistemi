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
    public partial class frmBrans : Form
    {
        public frmBrans()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            txtAd.Text = " ";
            txtID.Text = " ";
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void frmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblBranslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekleBrans = new SqlCommand("insert into tblBranslar(bransAd) values(@p1)",bgl.baglanti());
            ekleBrans.Parameters.AddWithValue("@p1", txtAd.Text);
            ekleBrans.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş başarılı bir şekilde eklendi...");
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand silBrans = new SqlCommand("delete from tblBranslar where bransID=@b1",bgl.baglanti());
            silBrans.Parameters.AddWithValue("@b1", txtID.Text);
            silBrans.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş başarılı bir şekilde silindi...");
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update tblBranslar set bransAd=@g1 where bransID=@g2", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@g1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@g2", txtID.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş başarılı bir şekilde güncellendi...");
            temizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblBranslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
