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
    public partial class dilsecim : Form
    {
        public dilsecim()
        {
            InitializeComponent();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            enmenu yeni = new enmenu();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            trmenu yeni = new trmenu();
            yeni.Show();
            this.Hide();
        }
    }
}
