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
    public partial class sube : Form
    {
        public sube()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost ; port=5432 ; database=1 ; user Id=postgres ; password=1234");

        private void subeEkle_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text==""||textBox3.Text=="" || int.Parse(textBox2.Text) <= 0 || int.Parse(textBox3.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand ekle = new NpgsqlCommand("insert into \"sube\" (\"subeNo\",\"subeAdi\",\"bulunduguSehir\") values (@p3,@p1,@p2)", baglanti);
                ekle.Parameters.AddWithValue("@p1", textBox1.Text);
                ekle.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
                ekle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
                ekle.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void subeSil_Click(object sender, EventArgs e)
        {
            if(textBox3.Text=="" || int.Parse(textBox3.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand sil = new NpgsqlCommand("delete from \"sube\" where \"subeNo\"=@p1", baglanti);
                sil.Parameters.AddWithValue("@p1", int.Parse(textBox3.Text));
                sil.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void subeAra_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Hatalı veya eksik giriş");
            }
            else
            {
                baglanti.Open();
                DataTable tbl = new DataTable();
                NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select * from \"subeAra\"('%" + textBox1.Text + "%')", baglanti);
                ara.Fill(tbl);
                baglanti.Close();
                dataGridView1.DataSource = tbl;
            }
        }

        private void subeGuncelle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""  || textBox2.Text == "" || textBox3.Text == "" || int.Parse(textBox2.Text) <= 0 || int.Parse(textBox3.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand guncelle = new NpgsqlCommand("update \"sube\" set \"subeAdi\"=@p1,\"bulunduguSehir\"=@p2 where \"subeNo\"=@p3", baglanti);
                guncelle.Parameters.AddWithValue("@p1", textBox1.Text);
                guncelle.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
                guncelle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void subeListele_Click(object sender, EventArgs e)
        {
            string listele = "select distinct \"subeNo\" as \"Şube Numarası\",\"subeAdi\" as \"Şube Adı\",\"sehirNo\" as \"Şehir Numarası\",\"sehirAdi\" as \"Şehir Adı\" from sube join sehir on \"sehirNo\"=\"bulunduguSehir\" order by \"subeNo\" asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            ulke ulke = new ulke();
            ulke.Show();
            this.Hide();
        }
    }
}
