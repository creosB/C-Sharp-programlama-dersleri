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
    public partial class enmenu : Form
    {
        public enmenu()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dilsecim yeni = new dilsecim();
            yeni.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            enbildiri yeni = new enbildiri();
            yeni.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            ennedir yeni = new ennedir();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            enyapanlar yeni = new enyapanlar();
            yeni.Show();
            this.Hide();
        }
    }
}
