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
    public partial class alis : Form
    {
        public alis()
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

        private void AlislariListele_Click(object sender, EventArgs e)
        {
            string listele = "select * from \"alislariListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AlisEkle_Click(object sender, EventArgs e)
        {
            if (textBox6.Text=="" || int.Parse(textBox6.Text) <= 0 || textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || int.Parse(textBox1.Text) <= 0 || int.Parse(textBox4.Text) <= 0 || int.Parse(textBox5.Text) <= 0||Convert.ToDecimal(textBox2.Text)<=0) 
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand ekle = new NpgsqlCommand("insert into \"alis\" (\"alinanUrun\",\"alisFiyati\",\"alinanMiktar\",\"satanTedarikci\",\"alinanTarih\",\"alanSube\") values (@p1,@p2,@p4,@p5,@p6,@p7)", baglanti);
                ekle.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
                ekle.Parameters.AddWithValue("@p2", Convert.ToDecimal(textBox2.Text));
                ekle.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
                ekle.Parameters.AddWithValue("@p5", int.Parse(textBox5.Text));
                ekle.Parameters.AddWithValue("@p6", Convert.ToDateTime(dateTimePicker1.Text));
                ekle.Parameters.AddWithValue("@p7", int.Parse(textBox6.Text));
                ekle.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void AlisAra_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""|| textBox5.Text == "" || textBox6.Text == "" ||int.Parse(textBox1.Text)<=0|| int.Parse(textBox5.Text) <= 0 || int.Parse(textBox6.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                DataTable tbl = new DataTable();
                NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select distinct \"alisNo\" as \"Alış Numarası\",\"urunAdi\" as \"Alınan Ürün\",\"alisFiyati\" as \"Alış Fiyatı\",\"alinanMiktar\" as \"Alınan Miktar\",\"tedarikciAdi\" as \"Satan Tedarikçi\",\"subeAdi\" as \"Alan Şube\",\"alinanTarih\" as \"Alınan Tarih\" from alis join urun on \"alinanUrun\"=\"urunNo\" join tedarikci on \"satanTedarikci\"=\"tedarikciNo\" join sube on \"alanSube\"=\"subeNo\" where \"alinanUrun\"=" + int.Parse(textBox1.Text) + " or \"satanTedarikci\"=" + int.Parse(textBox5.Text) + " or \"alanSube\"=" + int.Parse(textBox6.Text) + " order by \"alisNo\" asc", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satis satis = new satis();
            satis.Show();
            this.Hide();
        }
    }
}
