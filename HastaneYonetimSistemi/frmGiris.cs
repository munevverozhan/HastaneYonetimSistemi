using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetimSistemi
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            frmHastaGiris hasta = new frmHastaGiris();
            hasta.Show();
            this.Hide();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            frmDoktorGiris doktor = new frmDoktorGiris();
            doktor.Show();
            this.Hide();


        }

        private void btnSekreter_Click(object sender, EventArgs e)
        {
            frmSekreterGiris frm = new frmSekreterGiris();
            frm.Show();
            this.Hide();


        }
    }
}
