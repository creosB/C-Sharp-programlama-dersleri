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
    public partial class ennedir : Form
    {
        public ennedir()
        {
            InitializeComponent();
        }

        private void Oku_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Human capital flight refers to the emigration of highly skilled or well-educated individuals.The net benefits of human capital flight for the sending country are sometimes referred to as a 'brain gain' whereas the net costs are sometimes referred to as a 'brain drain'.");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Untitled Projectt.mp3";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            enmenu yeni = new enmenu();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
