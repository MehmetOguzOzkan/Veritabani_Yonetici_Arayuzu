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
    public partial class kampanya : Form
    {
        public kampanya()
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

        private void KampanyaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand ekle = new NpgsqlCommand("insert into \"kampanyalar\" (\"kampanyaNo\",\"kampanyaAdi\",\"kampanyaYapilanSube\",\"kampanyaYapilanUrun\",\"kampanyaBaslamaTarihi\",\"kampanyaBitisTarihi\",\"kampanyaAciklamasi\") values (@p3,@p1,@p2,@p4,@p5,@p6,@p7)", baglanti);
            ekle.Parameters.AddWithValue("@p1", textBox1.Text);
            ekle.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
            ekle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
            ekle.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
            ekle.Parameters.AddWithValue("@p5", Convert.ToDateTime(dateTimePicker1.Text));
            ekle.Parameters.AddWithValue("@p6", Convert.ToDateTime(dateTimePicker2.Text));
            ekle.Parameters.AddWithValue("@p7", richTextBox1.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void KampanyalarıListele_Click(object sender, EventArgs e)
        {
            string listele = "select * from \"kampanyalariListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void KampanyaSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from \"kampanyalar\" where \"kampanyaNo\"=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", int.Parse(textBox3.Text));
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void KampanyaAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select distinct \"kampanyaNo\" as \"Kampanya Numarası\",\"kampanyaAdi\" as \"Kampanya Adı\",\"subeAdi\" as \"Kampanya Yapılan Şube\",\"urunAdi\" as \"Kampanya Yapılan Ürün\",\"kampanyaBaslamaTarihi\" as \"Kampanya Başlama Tarihi\",\"kampanyaBitisTarihi\" as \"Kampanya Bitiş Tarihi\",\"kampanyaAciklamasi\" as \"Kampanya Açıklaması\" from kampanyalar join sube on \"kampanyaYapilanSube\"=\"subeNo\" join urun on \"kampanyaYapilanUrun\"=\"urunNo\" and \"kampanyaAdi\" like '%" + textBox1.Text + "%' order by \"kampanyaNo\" asc", baglanti);
            ara.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void KampanyaGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand guncelle = new NpgsqlCommand("update \"kampanyalar\" set \"kampanyaAdi\"=@p1,\"kampanyaYapilanSube\"=@p2,\"kampanyaYapilanUrun\"=@p4,\"kampanyaBaslamaTarihi\"=@p5,\"kampanyaBitisTarihi\"=@p6,\"kampanyaAciklamasi\"=@p7 where \"kampanyaNo\"=@p3", baglanti);
            guncelle.Parameters.AddWithValue("@p1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
            guncelle.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
            guncelle.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
            guncelle.Parameters.AddWithValue("@p5", Convert.ToDateTime(dateTimePicker1.Text));
            guncelle.Parameters.AddWithValue("@p6", Convert.ToDateTime(dateTimePicker2.Text));
            guncelle.Parameters.AddWithValue("@p7", richTextBox1.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
