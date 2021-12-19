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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost ; port=5432 ; database=1 ; user Id=postgres ; password=1234");
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alis alis = new alis();
            alis.Show();
            this.Hide();
        }

        private void SatislariListele_Click(object sender, EventArgs e)
        {
            string listele = "select * from \"satislariListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void SatisEkle_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || int.Parse(textBox6.Text) <= 0 || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || int.Parse(textBox2.Text) <= 0 || int.Parse(textBox4.Text) <= 0 || int.Parse(textBox5.Text) <= 0 || Convert.ToDecimal(textBox3.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand ekle = new NpgsqlCommand("insert into \"satis\" (\"satilanUrun\",\"odenenTutar\",\"satilanUrunMiktari\",\"satanSube\",\"satinAlanMusteri\",\"satisTarihi\") values (@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                ekle.Parameters.AddWithValue("@p3", Convert.ToDecimal(textBox3.Text));
                ekle.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
                ekle.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
                ekle.Parameters.AddWithValue("@p5", int.Parse(textBox5.Text));
                ekle.Parameters.AddWithValue("@p6", int.Parse(textBox6.Text));
                ekle.Parameters.AddWithValue("@p7", Convert.ToDateTime(dateTimePicker1.Text));
                ekle.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void SatisAra_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox5.Text == "" || textBox6.Text == "" || int.Parse(textBox2.Text) <= 0 || int.Parse(textBox5.Text) <= 0 || int.Parse(textBox6.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                DataTable tbl = new DataTable();
                NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select distinct \"satisNo\" as \"Satış Numarası\",\"urunAdi\" as \"Satılan Ürün\",\"odenenTutar\" as \"Ödenen Tutar\",\"satilanUrunMiktari\" as \"Satılan Miktar\",\"subeAdi\" as \"Satan Şube\",\"musteriAdi\" as \"Satın Alan Müşteri\",\"satisTarihi\" as \"Satılan Tarih\" from satis join urun on \"satilanUrun\"=\"urunNo\" join sube on \"satanSube\"=\"subeNo\" join musteri on \"satinAlanMusteri\"=\"musteriNo\" where \"satilanUrun\"=" + int.Parse(textBox2.Text) + " or \"satanSube\"=" + int.Parse(textBox5.Text) + " or \"satinAlanMusteri\"=" + int.Parse(textBox6.Text) + " order by \"satisNo\" asc", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }
        }
    }
}
