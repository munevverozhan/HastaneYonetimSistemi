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
    public partial class frmSekreterGiris : Form
    {
        public frmSekreterGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sekreterTC, sekreterSifre,sekreterAdSoyad from tblSekreter where sekreterTC=@p1 and sekreterSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTextTC.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmSekreterDetay frm = new frmSekreterDetay();
                frm.adSoyad = dr[2].ToString();
                frm.tc = dr[0].ToString();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("T.C. Numaranız veya Şifreniz hatalı!","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();

        }
    }
}
