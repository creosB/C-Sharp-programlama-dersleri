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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void ayarlar_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }
        private void hakkında_Click(object sender, EventArgs e)
        {
            MessageBox.Show("----- 11-A SINIFI -----\nBARIŞ EROĞLU 2240\nFURKAN KOÇAK 3004\nDOĞUKAN HOROZ  3128");
        }

        private void nedir_Click(object sender, EventArgs e)
        {
            Form4 yeni = new Form4();
            yeni.Show();
            this.Hide();
        }

        private void arama_Click(object sender, EventArgs e)
        {
            Form7 yeni = new Form7();
            yeni.Show();
            this.Hide();
        }
    }
}
