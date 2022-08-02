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
    public partial class frmDoktorDetay : Form
    {
        public frmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        public string tc;
        public string adSoyad;

        private void frmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = adSoyad;
            lblTC.Text = tc;

            // randevu listesi gridview'ine veritabanından veri çekilmesi:
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select randevuTarih,randevuSaat,hastaTC,hastaSikayet from tblRandevular where randevuDoktor='"+adSoyad+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rtxtSikayet.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular frm = new frmDuyurular();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmDoktorBilgiDuzenle frm = new frmDoktorBilgiDuzenle();
            frm.tc = tc;
            frm.Show();
        }
    }
}
