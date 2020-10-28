using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeHazirlama
{
    public partial class tryapanlar : Form
    {
        public tryapanlar()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            dilsecim yeni = new dilsecim();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            trbildiri yeni = new trbildiri();
            yeni.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            trnedir yeni = new trnedir();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            tryapanlar yeni = new tryapanlar();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            trfizik yeni = new trfizik();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            trbiyoloji yeni = new trbiyoloji();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            trmatematik yeni = new trmatematik();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            trkimya yeni = new trkimya();
            yeni.Show();
            this.Hide();
        }
    }
}
