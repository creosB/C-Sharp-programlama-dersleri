using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,b,toplam,cik;

            a = Convert.ToInt16(sayi1.Text);
            b = Convert.ToInt16(sayi2.Text);
            toplam = (a + b);
            cik = (a - b);

            sonuc.Text = toplam.ToString();
            label5.Text = cik.ToString();

        }
    }
}
