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
    public partial class enyapanlar : Form
    {
        public enyapanlar()
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

            enbildiri yeni = new enbildiri();
            yeni.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            ennedir yeni = new ennedir();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            enyapanlar yeni = new enyapanlar();
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
            enfizik yeni = new enfizik();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            enbiyoloji yeni = new enbiyoloji();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            enmatematik yeni = new enmatematik();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            enkimya yeni = new enkimya();
            yeni.Show();
            this.Hide();
        }
    }
}
