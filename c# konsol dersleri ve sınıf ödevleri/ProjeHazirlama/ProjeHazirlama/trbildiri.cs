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
    public partial class trbildiri : Form
    {
        private int _ticks;

        public trbildiri()
        {           
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Top = 60;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            this.Text = _ticks.ToString();

            if (_ticks == 10)
            {
                this.Close();
            }
        }
    }
}
