using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Specific absorption rate (SAR) is a measure of the rate at which energy is absorbed by the human body when exposed to a radio frequency (RF) electromagnetic field. It can also refer to absorption of other forms of energy by tissue, including ultrasound.[1] It is defined as the power absorbed per mass of tissue and has units of watts per kilogram (W/kg)");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "english.mp3";
        }
    }
}
