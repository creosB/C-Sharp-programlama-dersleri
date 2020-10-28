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
    public partial class trbiyoloji : Form
    {
        public trbiyoloji()
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
            trgökhan yeni = new trgökhan();
            yeni.Show();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            trmehmet yeni = new trmehmet();
            yeni.Show();
        }
    }
}

