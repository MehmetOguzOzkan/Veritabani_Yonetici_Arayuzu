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
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost ; port=5432 ; database=1 ; user Id=postgres ; password=1234");

        private void MusteriListele_Click(object sender, EventArgs e)
        {
            string listele = "select * from \"musteriListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AboneleriListele_Click(object sender, EventArgs e)
        {
            string listele = "select * from \"aboneleriListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AboneOlmayanlariListele_Click(object sender, EventArgs e)
        {
            string listele = "select * from \"aboneOlmayanlariListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void MusteriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand ekle = new NpgsqlCommand("insert into \"musteri\" (\"musteriNo\",\"musteriAdi\",\"musteriSoyadi\",\"aboneMi?(E/H)\") values (@p3,@p1,@p2,@p4)", baglanti);
            ekle.Parameters.AddWithValue("@p1", textBox1.Text);
            ekle.Parameters.AddWithValue("@p2", textBox2.Text);
            ekle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
            ekle.Parameters.AddWithValue("@p4", Convert.ToChar(comboBox1.Text));
            ekle.ExecuteNonQuery();
            string sorgu = Convert.ToString(comboBox1.Text);
            if (sorgu == "E")
            {
                NpgsqlCommand aboneEkle = new NpgsqlCommand("update \"aboneler\" set \"abonelikBaslamaTarihi\"=@p5, \"abonelikBitisTarihi\"=@p6 where \"aboneMusteriNo\"=@p3 ", baglanti);
                aboneEkle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
                aboneEkle.Parameters.AddWithValue("@p5", Convert.ToDateTime(dateTimePicker1.Text));
                aboneEkle.Parameters.AddWithValue("@p6", Convert.ToDateTime(dateTimePicker2.Text));
                aboneEkle.ExecuteNonQuery();
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void MusteriSil_Click(object sender, EventArgs e)
        {
            if(textBox3.Text==""||int.Parse(textBox3.Text)<=0)
            {
                MessageBox.Show("Müşteri numarası bölümüne kabul edilebilir bir değer giriniz.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand sil = new NpgsqlCommand("delete from \"musteri\" where \"musteriNo\"=@p1", baglanti);
                sil.Parameters.AddWithValue("@p1", int.Parse(textBox3.Text));
                sil.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void MusteriAra_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Müşteri ad ve soyad bilgilerine kabul edilebilir değerler giriniz.");
            }
            else
            {
                baglanti.Open();
                DataTable tbl = new DataTable();
                NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select * from \"musteriAra\"('%" + textBox1.Text + "%','%" + textBox2.Text + "%')", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }
        }

        private void MusteriGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand guncelle = new NpgsqlCommand("update \"musteri\" set \"musteriAdi\"=@p1,\"musteriSoyadi\"=@p2,\"aboneMi?(E/H)\"=@p4 where \"musteriNo\"=@p3", baglanti);
            guncelle.Parameters.AddWithValue("@p1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@p2", textBox2.Text);
            guncelle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
            guncelle.Parameters.AddWithValue("@p4", comboBox1.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
