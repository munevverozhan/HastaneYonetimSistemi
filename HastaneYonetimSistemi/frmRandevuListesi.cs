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
    public partial class frmRandevuListesi : Form
    {
        public frmRandevuListesi()
        {
            InitializeComponent();
        }
        frmSekreterDetay detay = new frmSekreterDetay();

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void frmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblRandevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            detay.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            detay.tarih = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            detay.saat = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            detay.cbbrans = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            detay.cbdoktor = dataGridView1.Rows[secilen].Cells[4].Value.ToString();          
            detay.TC = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            detay.Show();
            this.Hide();
        }
    }
}
