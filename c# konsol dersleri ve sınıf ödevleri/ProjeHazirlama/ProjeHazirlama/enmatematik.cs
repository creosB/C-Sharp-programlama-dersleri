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
    public partial class enmatematik : Form
    {
        public enmatematik()
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
            enselman yeni = new enselman();
            yeni.Show();
        }
    }
}
