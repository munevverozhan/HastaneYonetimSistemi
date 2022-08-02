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
    public partial class frmHastaGiris : Form
    {
        public frmHastaGiris()
        {
            InitializeComponent();
        }
        public void temizle()
        {
            txtSifre.Text = " ";
            mskTextTC.Text ="";
        }

        private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaKayit hastaKayit = new frmHastaKayit();
            hastaKayit.Show();
            
        }

       

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tblHastalar where hastaTC=@a1 and hastaSifre=@a2", bgl.baglanti());
            komut.Parameters.AddWithValue("@a1", mskTextTC.Text);
            komut.Parameters.AddWithValue("@a2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmHastaDetay frm = new frmHastaDetay();
                frm.tcNo = mskTextTC.Text;
                frm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("T.C. Numaranızı veya Şifrenizi doğru giriniz!");
                temizle();
            }
            bgl.baglanti().Close();
        }
    }
}
