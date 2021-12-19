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
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost ; port=5432 ; database=1 ; user Id=postgres ; password=1234");
        private void button1_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.Show();
            this.Hide();
        }

        private void YoneticiEkle_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||textBox4.Text==""||int.Parse(textBox3.Text)<=0||int.Parse(textBox4.Text)<=0)
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand ekle = new NpgsqlCommand("insert into \"yoneticiler\" (\"yoneticiNo\",\"yoneticiAdi\",\"yoneticiSoyadi\",\"yonettigiSube\") values (@p3,@p1,@p2,@p4)", baglanti);
                ekle.Parameters.AddWithValue("@p1", textBox1.Text);
                ekle.Parameters.AddWithValue("@p2", textBox2.Text);
                ekle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
                ekle.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
                ekle.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void YöneticileriListele_Click(object sender, EventArgs e)
        {
            string listele = "select * from \"yoneticileriListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void YoneticiSil_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || int.Parse(textBox3.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand sil = new NpgsqlCommand("delete from \"yoneticiler\" where \"yoneticiNo\"=@p1", baglanti);
                sil.Parameters.AddWithValue("@p1", int.Parse(textBox3.Text));
                sil.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void YoneticiAra_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                DataTable tbl = new DataTable();
                NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select * from \"yoneticiAra\"('%" + textBox1.Text + "%','%" + textBox2.Text + "%')", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }
        }

        private void YoneticiGuncelle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || int.Parse(textBox3.Text) <= 0 || int.Parse(textBox4.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand guncelle = new NpgsqlCommand("update \"yoneticiler\" set \"yoneticiAdi\"=@p1,\"yoneticiSoyadi\"=@p2,\"yonettigiSube\"=@p4 where \"yoneticiNo\"=@p3", baglanti);
                guncelle.Parameters.AddWithValue("@p1", textBox1.Text);
                guncelle.Parameters.AddWithValue("@p2", textBox2.Text);
                guncelle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
                guncelle.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
