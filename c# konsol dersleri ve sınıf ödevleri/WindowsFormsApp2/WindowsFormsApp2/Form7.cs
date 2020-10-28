using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database4.accdb");

        void baglan()
        {
            try
            {                       
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'database4DataSet4.telefon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.telefonTableAdapter2.Fill(this.database4DataSet4.telefon);
            // TODO: Bu kod satırı 'database4DataSet3.telefon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.telefonTableAdapter1.Fill(this.database4DataSet3.telefon);
            // TODO: Bu kod satırı 'database4DataSet2.telefon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.telefonTableAdapter.Fill(this.database4DataSet2.telefon);

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            baglan();
            DataTable data = new DataTable();
            OleDbDataAdapter ekle = new OleDbDataAdapter("SELECT * FROM telefon WHERE model LIKE '%" + bunifuTextbox1.text + "%'", baglanti);
            ekle.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void arama_Click(object sender, EventArgs e)
        {
            Form7 yeni = new Form7();
            yeni.Show();
            this.Hide();
        }

        private void nedir_Click(object sender, EventArgs e)
        {
            Form4 yeni = new Form4();
            yeni.Show();
            this.Hide();
        }

        private void hakkında_Click(object sender, EventArgs e)
        {
            MessageBox.Show("----- 11-A SINIFI -----\nBARIŞ EROĞLU 2240\nFURKAN KOÇAK 3004\nDOĞUKAN HOROZ  3128");
        }

        private void ayarlar_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }
    }
}
