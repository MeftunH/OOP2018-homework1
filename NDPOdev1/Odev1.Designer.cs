namespace WindowsFormsApp22
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txttcara = new System.Windows.Forms.TextBox();
            this.tcara = new System.Windows.Forms.Button();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcocuksayisi = new System.Windows.Forms.TextBox();
            this.txtesicalisiyormu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtevlilik = new System.Windows.Forms.TextBox();
            this.txtcalismasuresi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmkmtazminati = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txttbnmaas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtresim = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtvergimatrahi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtfzlmesai = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtfzlmesaisaatucreti = new System.Windows.Forms.TextBox();
            this.txtidarigrvtzmnti = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txtbxmaas = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dosya Oku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 266);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(303, 269);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, -1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1417, 261);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // txttcara
            // 
            this.txttcara.Location = new System.Drawing.Point(324, 383);
            this.txttcara.Name = "txttcara";
            this.txttcara.Size = new System.Drawing.Size(150, 22);
            this.txttcara.TabIndex = 4;
            this.txttcara.TextChanged += new System.EventHandler(this.txttcara_TextChanged);
            this.txttcara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttcara_KeyPress);
            // 
            // tcara
            // 
            this.tcara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tcara.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcara.ForeColor = System.Drawing.Color.Yellow;
            this.tcara.Location = new System.Drawing.Point(480, 374);
            this.tcara.Name = "tcara";
            this.tcara.Size = new System.Drawing.Size(75, 42);
            this.tcara.TabIndex = 5;
            this.tcara.Text = "TC ARA";
            this.tcara.UseVisualStyleBackColor = false;
            this.tcara.Click += new System.EventHandler(this.tcara_Click);
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(125, 592);
            this.txttc.Name = "txttc";
            this.txttc.ReadOnly = true;
            this.txttc.Size = new System.Drawing.Size(150, 22);
            this.txttc.TabIndex = 6;
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(125, 637);
            this.txtisim.Name = "txtisim";
            this.txtisim.ReadOnly = true;
            this.txtisim.Size = new System.Drawing.Size(150, 22);
            this.txtisim.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Isim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 730);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Yas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 681);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Soyisim";
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(125, 730);
            this.txtyas.Name = "txtyas";
            this.txtyas.ReadOnly = true;
            this.txtyas.Size = new System.Drawing.Size(150, 22);
            this.txtyas.TabIndex = 11;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(125, 681);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.ReadOnly = true;
            this.txtsoyisim.Size = new System.Drawing.Size(150, 22);
            this.txtsoyisim.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(2, 782);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cocuk Sayisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(331, 682);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Esi Calisiyor mu";
            // 
            // txtcocuksayisi
            // 
            this.txtcocuksayisi.Location = new System.Drawing.Point(125, 782);
            this.txtcocuksayisi.Name = "txtcocuksayisi";
            this.txtcocuksayisi.ReadOnly = true;
            this.txtcocuksayisi.Size = new System.Drawing.Size(150, 22);
            this.txtcocuksayisi.TabIndex = 19;
            // 
            // txtesicalisiyormu
            // 
            this.txtesicalisiyormu.Location = new System.Drawing.Point(484, 682);
            this.txtesicalisiyormu.Name = "txtesicalisiyormu";
            this.txtesicalisiyormu.ReadOnly = true;
            this.txtesicalisiyormu.Size = new System.Drawing.Size(150, 22);
            this.txtesicalisiyormu.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(342, 641);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Evlilik durumu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(342, 592);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Calisma suresi";
            // 
            // txtevlilik
            // 
            this.txtevlilik.Location = new System.Drawing.Point(484, 637);
            this.txtevlilik.Name = "txtevlilik";
            this.txtevlilik.ReadOnly = true;
            this.txtevlilik.Size = new System.Drawing.Size(150, 22);
            this.txtevlilik.TabIndex = 15;
            // 
            // txtcalismasuresi
            // 
            this.txtcalismasuresi.Location = new System.Drawing.Point(484, 592);
            this.txtcalismasuresi.Name = "txtcalismasuresi";
            this.txtcalismasuresi.ReadOnly = true;
            this.txtcalismasuresi.Size = new System.Drawing.Size(150, 22);
            this.txtcalismasuresi.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(321, 786);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Makam Tazminati";
            // 
            // txtmkmtazminati
            // 
            this.txtmkmtazminati.Location = new System.Drawing.Point(484, 782);
            this.txtmkmtazminati.Name = "txtmkmtazminati";
            this.txtmkmtazminati.ReadOnly = true;
            this.txtmkmtazminati.Size = new System.Drawing.Size(150, 22);
            this.txtmkmtazminati.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(355, 732);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Taban Maas";
            // 
            // txttbnmaas
            // 
            this.txttbnmaas.Location = new System.Drawing.Point(484, 731);
            this.txttbnmaas.Name = "txttbnmaas";
            this.txttbnmaas.ReadOnly = true;
            this.txttbnmaas.Size = new System.Drawing.Size(150, 22);
            this.txttbnmaas.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(753, 782);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 18);
            this.label11.TabIndex = 35;
            this.label11.Text = "Personel Resim Yolu";
            // 
            // txtresim
            // 
            this.txtresim.Location = new System.Drawing.Point(948, 785);
            this.txtresim.Name = "txtresim";
            this.txtresim.ReadOnly = true;
            this.txtresim.Size = new System.Drawing.Size(150, 22);
            this.txtresim.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(774, 726);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Vergi Matrahi";
            // 
            // txtvergimatrahi
            // 
            this.txtvergimatrahi.Location = new System.Drawing.Point(948, 722);
            this.txtvergimatrahi.Name = "txtvergimatrahi";
            this.txtvergimatrahi.ReadOnly = true;
            this.txtvergimatrahi.Size = new System.Drawing.Size(150, 22);
            this.txtvergimatrahi.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(750, 637);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Fazla Mesai Saati";
            // 
            // txtfzlmesai
            // 
            this.txtfzlmesai.Location = new System.Drawing.Point(948, 641);
            this.txtfzlmesai.Name = "txtfzlmesai";
            this.txtfzlmesai.ReadOnly = true;
            this.txtfzlmesai.Size = new System.Drawing.Size(150, 22);
            this.txtfzlmesai.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(731, 681);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "Fazla Mesai Saat Ucreti";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(750, 592);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 18);
            this.label15.TabIndex = 28;
            this.label15.Text = "Idari Gorev Tazminati";
            // 
            // txtfzlmesaisaatucreti
            // 
            this.txtfzlmesaisaatucreti.Location = new System.Drawing.Point(948, 682);
            this.txtfzlmesaisaatucreti.Name = "txtfzlmesaisaatucreti";
            this.txtfzlmesaisaatucreti.ReadOnly = true;
            this.txtfzlmesaisaatucreti.Size = new System.Drawing.Size(150, 22);
            this.txtfzlmesaisaatucreti.TabIndex = 27;
            // 
            // txtidarigrvtzmnti
            // 
            this.txtidarigrvtzmnti.Location = new System.Drawing.Point(948, 592);
            this.txtidarigrvtzmnti.Name = "txtidarigrvtzmnti";
            this.txtidarigrvtzmnti.ReadOnly = true;
            this.txtidarigrvtzmnti.Size = new System.Drawing.Size(150, 22);
            this.txtidarigrvtzmnti.TabIndex = 26;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnhesapla.Location = new System.Drawing.Point(828, 274);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(156, 35);
            this.btnhesapla.TabIndex = 36;
            this.btnhesapla.Text = "MAAS HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txtbxmaas
            // 
            this.txtbxmaas.Location = new System.Drawing.Point(661, 281);
            this.txtbxmaas.Name = "txtbxmaas";
            this.txtbxmaas.Size = new System.Drawing.Size(150, 22);
            this.txtbxmaas.TabIndex = 37;
            this.txtbxmaas.TextChanged += new System.EventHandler(this.txtbxmaas_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApp22.Properties.Resources.prsnlrsm1;
            this.pictureBox1.Image = global::WindowsFormsApp22.Properties.Resources.prsnlrsm1;
            this.pictureBox1.Location = new System.Drawing.Point(756, 880);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1432, 1055);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtbxmaas);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtresim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtvergimatrahi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtfzlmesai);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtfzlmesaisaatucreti);
            this.Controls.Add(this.txtidarigrvtzmnti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtmkmtazminati);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txttbnmaas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcocuksayisi);
            this.Controls.Add(this.txtesicalisiyormu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtevlilik);
            this.Controls.Add(this.txtcalismasuresi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.tcara);
            this.Controls.Add(this.txttcara);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Odev1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txttcara;
        private System.Windows.Forms.Button tcara;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcocuksayisi;
        private System.Windows.Forms.TextBox txtesicalisiyormu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtevlilik;
        private System.Windows.Forms.TextBox txtcalismasuresi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmkmtazminati;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttbnmaas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtresim;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtvergimatrahi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtfzlmesai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtfzlmesaisaatucreti;
        private System.Windows.Forms.TextBox txtidarigrvtzmnti;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txtbxmaas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

