
namespace SQL
{
    partial class tedarikci
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TedarikciAra = new System.Windows.Forms.Button();
            this.TedarikciSil = new System.Windows.Forms.Button();
            this.TedarikciGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TedarikciEkle = new System.Windows.Forms.Button();
            this.TedarikciListele = new System.Windows.Forms.Button();
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
            this.button3.TabIndex = 56;
            this.button3.Text = "Anasayfaya Dön";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(641, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tedarikçi Numarası";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(774, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 53;
            // 
            // TedarikciAra
            // 
            this.TedarikciAra.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TedarikciAra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TedarikciAra.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TedarikciAra.Location = new System.Drawing.Point(645, 311);
            this.TedarikciAra.Name = "TedarikciAra";
            this.TedarikciAra.Size = new System.Drawing.Size(150, 30);
            this.TedarikciAra.TabIndex = 52;
            this.TedarikciAra.Text = "Tedarikçi Ara";
            this.TedarikciAra.UseVisualStyleBackColor = false;
            this.TedarikciAra.Click += new System.EventHandler(this.TedarikciAra_Click);
            // 
            // TedarikciSil
            // 
            this.TedarikciSil.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TedarikciSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TedarikciSil.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TedarikciSil.Location = new System.Drawing.Point(645, 275);
            this.TedarikciSil.Name = "TedarikciSil";
            this.TedarikciSil.Size = new System.Drawing.Size(150, 30);
            this.TedarikciSil.TabIndex = 51;
            this.TedarikciSil.Text = "Tedarikçi Sil";
            this.TedarikciSil.UseVisualStyleBackColor = false;
            this.TedarikciSil.Click += new System.EventHandler(this.TedarikciSil_Click);
            // 
            // TedarikciGuncelle
            // 
            this.TedarikciGuncelle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TedarikciGuncelle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TedarikciGuncelle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TedarikciGuncelle.Location = new System.Drawing.Point(645, 347);
            this.TedarikciGuncelle.Name = "TedarikciGuncelle";
            this.TedarikciGuncelle.Size = new System.Drawing.Size(150, 30);
            this.TedarikciGuncelle.TabIndex = 50;
            this.TedarikciGuncelle.Text = "Tedarikçi Güncelle";
            this.TedarikciGuncelle.UseVisualStyleBackColor = false;
            this.TedarikciGuncelle.Click += new System.EventHandler(this.TedarikciGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(641, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tedarikçi Adı";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(774, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 46;
            // 
            // TedarikciEkle
            // 
            this.TedarikciEkle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TedarikciEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TedarikciEkle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TedarikciEkle.Location = new System.Drawing.Point(645, 239);
            this.TedarikciEkle.Name = "TedarikciEkle";
            this.TedarikciEkle.Size = new System.Drawing.Size(150, 30);
            this.TedarikciEkle.TabIndex = 45;
            this.TedarikciEkle.Text = "Tedarikçi Ekle";
            this.TedarikciEkle.UseVisualStyleBackColor = false;
            this.TedarikciEkle.Click += new System.EventHandler(this.TedarikciEkle_Click);
            // 
            // TedarikciListele
            // 
            this.TedarikciListele.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TedarikciListele.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TedarikciListele.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TedarikciListele.Location = new System.Drawing.Point(645, 383);
            this.TedarikciListele.Name = "TedarikciListele";
            this.TedarikciListele.Size = new System.Drawing.Size(150, 30);
            this.TedarikciListele.TabIndex = 44;
            this.TedarikciListele.Text = "Tedarikçileri Listele";
            this.TedarikciListele.UseVisualStyleBackColor = false;
            this.TedarikciListele.Click += new System.EventHandler(this.TedarikciListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 437);
            this.dataGridView1.TabIndex = 43;
            // 
            // tedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TedarikciAra);
            this.Controls.Add(this.TedarikciSil);
            this.Controls.Add(this.TedarikciGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TedarikciEkle);
            this.Controls.Add(this.TedarikciListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tedarikci";
            this.Text = "Tedarikçiler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button TedarikciAra;
        private System.Windows.Forms.Button TedarikciSil;
        private System.Windows.Forms.Button TedarikciGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TedarikciEkle;
        private System.Windows.Forms.Button TedarikciListele;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}