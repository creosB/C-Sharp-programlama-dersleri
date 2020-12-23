using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_sipariş
{
    public partial class giriş_panel : Form
    {
        public giriş_panel()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "admin" && bunifuMetroTextbox2.Text == "12345")
            {
                Form1 yeni = new Form1();
                yeni.Show();
                this.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
