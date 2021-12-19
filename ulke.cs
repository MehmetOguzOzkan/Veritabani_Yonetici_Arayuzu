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
    public partial class ulke : Form
    {
        public ulke()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost ; port=5432 ; database=1 ; user Id=postgres ; password=1234");

        private void ulkeEkle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || int.Parse(textBox3.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand ekle = new NpgsqlCommand("insert into \"ulke\" (\"ulkeNo\",\"ulkeAdi\") values (@p3,@p1)", baglanti);
                ekle.Parameters.AddWithValue("@p1", textBox1.Text);
                ekle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
                ekle.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void ulkeSil_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || int.Parse(textBox3.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand sil = new NpgsqlCommand("delete from \"ulke\" where \"ulkeNo\"=@p1", baglanti);
                sil.Parameters.AddWithValue("@p1", int.Parse(textBox3.Text));
                sil.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void ulkeAra_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                DataTable tbl = new DataTable();
                NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select * from \"ulkeAra\"('%" + textBox1.Text + "%')", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }
        }

        private void ulkeGuncelle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || int.Parse(textBox3.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand guncelle = new NpgsqlCommand("update \"ulke\" set \"ulkeAdi\"=@p1 where \"ulkeNo\"=@p3", baglanti);
                guncelle.Parameters.AddWithValue("@p1", textBox1.Text);
                guncelle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void ulkeListele_Click(object sender, EventArgs e)
        {
            string listele = "select * from \"ulkeListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sube sube = new sube();
            sube.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sehir sehir = new sehir();
            sehir.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
