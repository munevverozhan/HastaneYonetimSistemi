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
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("select doktorTC, doktorSifre, doktorAd,doktorSoyad from tblDoktor where doktorTC=@p1 and doktorSifre=@p2", bgl.baglanti());
            giris.Parameters.AddWithValue("@p1", mskTextTC.Text);
            giris.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                frmDoktorDetay detay = new frmDoktorDetay();
                detay.tc = dr[0].ToString();
                detay.adSoyad = dr[2] + " " + dr[3];
                detay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("T.C.Numaranız ya da Şifreniz hatalı girildi!!!");
            }
            bgl.baglanti().Close();
        }
    }
}
