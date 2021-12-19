using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost ; port=5432 ; database=1 ; user Id=postgres ; password=1234");

        private void button1_Click(object sender, EventArgs e)
        {
            sube sube = new sube();
            sube.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteri musteri = new musteri();
            musteri.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kampanya kampanya = new kampanya();
            kampanya.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            urun urun = new urun();
            urun.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tedarikci tedarikci = new tedarikci();
            tedarikci.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            alis alis = new alis();
            alis.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            iletisim iletisim = new iletisim();
            iletisim.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}