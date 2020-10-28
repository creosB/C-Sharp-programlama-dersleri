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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
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

        private void nedir_Click(object sender, EventArgs e)
        {
            Form5 yeni = new Form5();
            yeni.Show();
            this.Hide();
        }

        private void hakkında_Click(object sender, EventArgs e)
        {
            MessageBox.Show("----- 11-A CLASS -----\nBARIŞ EROĞLU 2240\nFURKAN KOÇAK 3004\nDOĞUKAN HOROZ  3128");
        }

        private void arama_Click(object sender, EventArgs e)
        {
            Form7 yeni = new Form7();
            yeni.Show();
            this.Hide();
        }
    }
}
