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
    public partial class iletisim : Form
    {
        public iletisim()
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
            string listele = "select * from \"subeIletisimleriListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void PersonelleriListele_Click(object sender, EventArgs e)
        {
            string listele = "select * from \"personelIletisimleriListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void TedarikcileriListele_Click(object sender, EventArgs e)
        {
            string listele = "select * from \"tedarikciIletisimleriListele\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(listele, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void TedarikciGuncelle_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||textBox4.Text==""||richTextBox1.Text==""||int.Parse(textBox1.Text)<=0||int.Parse(textBox2.Text)<=0||int.Parse(textBox4.Text)<=0)
            {
                MessageBox.Show("Hatalı veya eksik giriş yaptınız. Lütfen kabul edilebilir bir giriş yapınız.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand guncelle = new NpgsqlCommand("update \"tedarikciIletisim\" set \"tedarikciTelefonNo\"=@p2,\"tedarikciEPosta\"=@p3,\"tedarikciFaks\"=@p4,\"tedarikciAdres\"=@p5 where \"iletisimTedarikciNo\"=@p1", baglanti);
                guncelle.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
                guncelle.Parameters.AddWithValue("@p3", textBox3.Text);
                guncelle.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
                guncelle.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
                guncelle.Parameters.AddWithValue("@p5", richTextBox1.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void PersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || richTextBox1.Text == "" || int.Parse(textBox1.Text) <= 0 || int.Parse(textBox2.Text) <= 0 || int.Parse(textBox4.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş yaptınız. Lütfen kabul edilebilir bir giriş yapınız.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand guncelle = new NpgsqlCommand("personelIletisim\" set \"personelTelefonNo\"=@p2,\"personelEPosta\"=@p3,\"personelFaks\"=@p4,\"personelAdres\"=@p5 where \"iletisimPersonelNo\"=@p1", baglanti);
                guncelle.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
                guncelle.Parameters.AddWithValue("@p3", textBox3.Text);
                guncelle.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
                guncelle.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
                guncelle.Parameters.AddWithValue("@p5", richTextBox1.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void SubeGuncelle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || richTextBox1.Text == "" || int.Parse(textBox1.Text) <= 0 || int.Parse(textBox2.Text) <= 0 || int.Parse(textBox4.Text) <= 0)
            {
                MessageBox.Show("Hatalı veya eksik giriş yaptınız. Lütfen kabul edilebilir bir giriş yapınız.");
            }
            else
            {
                baglanti.Open();
                NpgsqlCommand guncelle = new NpgsqlCommand("update \"subeIletisim\" set \"subeTelefonNo\"=@p2,\"subeEPosta\"=@p3,\"subeFaks\"=@p4,\"subeAdres\"=@p5 where \"iletisimSubeNo\"=@p1", baglanti);
                guncelle.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
                guncelle.Parameters.AddWithValue("@p3", textBox3.Text);
                guncelle.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
                guncelle.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
                guncelle.Parameters.AddWithValue("@p5", richTextBox1.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
        }
    }
}
