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

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spesific Absorption Rate, yani Türkçesi ile Özgül Emilim Oranı anlamına gelen SAR, vücudunuz tarafından soğurulan enerjinin miktarını ölçümlendirmek için kullanılan bir değerdir. Yani kısacası telefonlarınız üzerinden yola çıkacak olursak –ki en çok ilgilendiğiniz kısmı da o. Muhtemelen – telefonunuzu kullanırken ne kadar radyoaktif enerjiye maruz kaldığınızın ölçüsüdür SAR.");
    }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Untitled Project.mp3";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();
        }
    }
}
