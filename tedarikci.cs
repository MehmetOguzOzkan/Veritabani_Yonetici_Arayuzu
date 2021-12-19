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
    public partial class tedarikci : Form
    {
        public tedarikci()
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

        private void TedarikciSil_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || int.Parse(textBox3.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand sil = new NpgsqlCommand("delete from \"tedarikci\" where \"tedarikciNo\"=@p1", baglanti);
                sil.Parameters.AddWithValue("@p1", int.Parse(textBox3.Text));
                sil.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void TedarikciEkle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || int.Parse(textBox3.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand ekle = new NpgsqlCommand("insert into \"tedarikci\" (\"tedarikciNo\",\"tedarikciAdi\") values (@p3,@p1)", baglanti);
                ekle.Parameters.AddWithValue("@p1", textBox1.Text);
                ekle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
                ekle.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void TedarikciListele_Click(object sender, EventArgs e)
        {
            string listele = "select * from \"tedarikcileriListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void TedarikciAra_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Hatalı veya eksik giriş");
            }
            else
            {
                baglanti.Open();
                DataTable tbl = new DataTable();
                NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select * from \"tedarikciAra\"('%" + textBox1.Text + "%')", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }
        }

        private void TedarikciGuncelle_Click(object sender, EventArgs e)
        { 
            if (textBox3.Text == "" || int.Parse(textBox3.Text)<=0)
            {
                MessageBox.Show("Hatalı veya eksik giriş");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand guncelle = new NpgsqlCommand("update \"tedarikci\" set \"tedarikciAdi\"=@p1 where \"tedarikciNo\"=@p3", baglanti);
                guncelle.Parameters.AddWithValue("@p1", textBox1.Text);
                guncelle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
        }
    }
}
