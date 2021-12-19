
namespace SQL
{
    partial class urun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.UrunAra = new System.Windows.Forms.Button();
            this.UrunSil = new System.Windows.Forms.Button();
            this.UrunGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UrunEkle = new System.Windows.Forms.Button();
            this.UrunListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Bisque;
            this.button3.Location = new System.Drawing.Point(645, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 30);
            this.button3.TabIndex = 42;
            this.button3.Text = "Anasayfaya Dön";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(645, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 40;
            this.button1.Text = "Stok Bilgilerini Düzenle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(641, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ürün Numarası";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(772, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 38;
            // 
            // UrunAra
            // 
            this.UrunAra.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UrunAra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunAra.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UrunAra.Location = new System.Drawing.Point(645, 275);
            this.UrunAra.Name = "UrunAra";
            this.UrunAra.Size = new System.Drawing.Size(150, 30);
            this.UrunAra.TabIndex = 37;
            this.UrunAra.Text = "Ürün Ara";
            this.UrunAra.UseVisualStyleBackColor = false;
            this.UrunAra.Click += new System.EventHandler(this.UrunAra_Click);
            // 
            // UrunSil
            // 
            this.UrunSil.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UrunSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunSil.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UrunSil.Location = new System.Drawing.Point(645, 239);
            this.UrunSil.Name = "UrunSil";
            this.UrunSil.Size = new System.Drawing.Size(150, 30);
            this.UrunSil.TabIndex = 36;
            this.UrunSil.Text = "Ürün Sil";
            this.UrunSil.UseVisualStyleBackColor = false;
            this.UrunSil.Click += new System.EventHandler(this.UrunSil_Click);
            // 
            // UrunGuncelle
            // 
            this.UrunGuncelle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UrunGuncelle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunGuncelle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UrunGuncelle.Location = new System.Drawing.Point(645, 311);
            this.UrunGuncelle.Name = "UrunGuncelle";
            this.UrunGuncelle.Size = new System.Drawing.Size(150, 30);
            this.UrunGuncelle.TabIndex = 35;
            this.UrunGuncelle.Text = "Ürün Güncelle";
            this.UrunGuncelle.UseVisualStyleBackColor = false;
            this.UrunGuncelle.Click += new System.EventHandler(this.UrunGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(641, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(641, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ürün Adı";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(772, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(772, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 31;
            // 
            // UrunEkle
            // 
            this.UrunEkle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UrunEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunEkle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UrunEkle.Location = new System.Drawing.Point(645, 203);
            this.UrunEkle.Name = "UrunEkle";
            this.UrunEkle.Size = new System.Drawing.Size(150, 30);
            this.UrunEkle.TabIndex = 30;
            this.UrunEkle.Text = "Ürün Ekle";
            this.UrunEkle.UseVisualStyleBackColor = false;
            this.UrunEkle.Click += new System.EventHandler(this.UrunEkle_Click);
            // 
            // UrunListele
            // 
            this.UrunListele.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UrunListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrunListele.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UrunListele.Location = new System.Drawing.Point(645, 347);
            this.UrunListele.Name = "UrunListele";
            this.UrunListele.Size = new System.Drawing.Size(150, 30);
            this.UrunListele.TabIndex = 29;
            this.UrunListele.Text = "Ürünleri Listele";
            this.UrunListele.UseVisualStyleBackColor = false;
            this.UrunListele.Click += new System.EventHandler(this.UrunListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 437);
            this.dataGridView1.TabIndex = 28;
            // 
            // urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.UrunAra);
            this.Controls.Add(this.UrunSil);
            this.Controls.Add(this.UrunGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UrunEkle);
            this.Controls.Add(this.UrunListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "urun";
            this.Text = "Ürün";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button UrunAra;
        private System.Windows.Forms.Button UrunSil;
        private System.Windows.Forms.Button UrunGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button UrunEkle;
        private System.Windows.Forms.Button UrunListele;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}