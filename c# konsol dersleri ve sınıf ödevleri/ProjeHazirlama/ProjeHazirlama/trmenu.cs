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
    public partial class trmenu : Form
    {
        public trmenu()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dilsecim yeni = new dilsecim();
            yeni.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            trbildiri yeni = new trbildiri();
            yeni.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            trnedir yeni = new trnedir();
            yeni.Show();
            this.Hide();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            tryapanlar yeni = new tryapanlar();
            yeni.Show();
            this.Hide();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
