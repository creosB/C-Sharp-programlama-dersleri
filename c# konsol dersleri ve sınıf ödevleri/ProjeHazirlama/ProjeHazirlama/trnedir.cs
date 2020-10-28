using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProjeHazirlama
{
    public partial class trnedir : Form
    {
        public trnedir()
        {
            InitializeComponent();
        }

        private void Oku_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beyin göçü, yetiştirilmesi için büyük kaynak gerektiren veya yetiştiği halde ilgisizlik ve olanaksızlık nedeniyle bilim insanı, hekim, mühendis vb. gibi vasıflı insan gücünün daha gelişmiş bir ülkeye göç etmesi.");
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            dilsecim yeni = new dilsecim();
            yeni.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Untitled Project.mp3";
        }
    }
}
