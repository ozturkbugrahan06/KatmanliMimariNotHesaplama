
namespace Öğrenci_Not
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbKulüp = new System.Windows.Forms.ComboBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Notlar = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtS3 = new System.Windows.Forms.TextBox();
            this.btnNotListele = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNotGuncelle = new System.Windows.Forms.Button();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtOgrId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Kulüpler = new System.Windows.Forms.GroupBox();
            this.btnKulüpListele = new System.Windows.Forms.Button();
            this.btnKulüpGuncelle = new System.Windows.Forms.Button();
            this.btnKulüpSil = new System.Windows.Forms.Button();
            this.btnKulüpKaydet = new System.Windows.Forms.Button();
            this.txtkulupAd = new System.Windows.Forms.TextBox();
            this.txtkulupId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.Notlar.SuspendLayout();
            this.Kulüpler.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.cbKulüp);
            this.groupBox1.Controls.Add(this.txtFoto);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(166, 180);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 13;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(85, 180);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(166, 151);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(85, 151);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbKulüp
            // 
            this.cbKulüp.FormattingEnabled = true;
            this.cbKulüp.Location = new System.Drawing.Point(85, 124);
            this.cbKulüp.Name = "cbKulüp";
            this.cbKulüp.Size = new System.Drawing.Size(156, 21);
            this.cbKulüp.TabIndex = 9;
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(85, 98);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(156, 20);
            this.txtFoto.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(85, 69);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(156, 20);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(85, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(156, 20);
            this.txtAd.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(85, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(156, 20);
            this.txtID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "KULÜP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FOTOĞRAF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // Notlar
            // 
            this.Notlar.Controls.Add(this.btnHesapla);
            this.Notlar.Controls.Add(this.txtDurum);
            this.Notlar.Controls.Add(this.label8);
            this.Notlar.Controls.Add(this.txtOrt);
            this.Notlar.Controls.Add(this.label7);
            this.Notlar.Controls.Add(this.txtProje);
            this.Notlar.Controls.Add(this.label6);
            this.Notlar.Controls.Add(this.txtS3);
            this.Notlar.Controls.Add(this.btnNotListele);
            this.Notlar.Controls.Add(this.label12);
            this.Notlar.Controls.Add(this.btnNotGuncelle);
            this.Notlar.Controls.Add(this.txtS2);
            this.Notlar.Controls.Add(this.label11);
            this.Notlar.Controls.Add(this.txtS1);
            this.Notlar.Controls.Add(this.txtOgrId);
            this.Notlar.Controls.Add(this.label9);
            this.Notlar.Controls.Add(this.label10);
            this.Notlar.Location = new System.Drawing.Point(299, 0);
            this.Notlar.Name = "Notlar";
            this.Notlar.Size = new System.Drawing.Size(281, 220);
            this.Notlar.TabIndex = 1;
            this.Notlar.TabStop = false;
            this.Notlar.Text = "NOTLAR";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(173, 127);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 20;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(190, 95);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(32, 20);
            this.txtDurum.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "DURUM:";
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(190, 69);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(32, 20);
            this.txtOrt.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "ORT:";
            // 
            // txtProje
            // 
            this.txtProje.Location = new System.Drawing.Point(190, 43);
            this.txtProje.Name = "txtProje";
            this.txtProje.Size = new System.Drawing.Size(32, 20);
            this.txtProje.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "PROJE:";
            // 
            // txtS3
            // 
            this.txtS3.Location = new System.Drawing.Point(85, 94);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(32, 20);
            this.txtS3.TabIndex = 10;
            // 
            // btnNotListele
            // 
            this.btnNotListele.Location = new System.Drawing.Point(92, 127);
            this.btnNotListele.Name = "btnNotListele";
            this.btnNotListele.Size = new System.Drawing.Size(75, 23);
            this.btnNotListele.TabIndex = 13;
            this.btnNotListele.Text = "LİSTELE";
            this.btnNotListele.UseVisualStyleBackColor = true;
            this.btnNotListele.Click += new System.EventHandler(this.btnNotListele_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "SINAV3:";
            // 
            // btnNotGuncelle
            // 
            this.btnNotGuncelle.Location = new System.Drawing.Point(11, 127);
            this.btnNotGuncelle.Name = "btnNotGuncelle";
            this.btnNotGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnNotGuncelle.TabIndex = 12;
            this.btnNotGuncelle.Text = "GÜNCELLE";
            this.btnNotGuncelle.UseVisualStyleBackColor = true;
            this.btnNotGuncelle.Click += new System.EventHandler(this.btnNotGuncelle_Click);
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(85, 69);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(32, 20);
            this.txtS2.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "SINAV2:";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(85, 43);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(32, 20);
            this.txtS1.TabIndex = 6;
            // 
            // txtOgrId
            // 
            this.txtOgrId.Location = new System.Drawing.Point(85, 19);
            this.txtOgrId.Name = "txtOgrId";
            this.txtOgrId.Size = new System.Drawing.Size(32, 20);
            this.txtOgrId.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "SINAV1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // Kulüpler
            // 
            this.Kulüpler.Controls.Add(this.btnKulüpListele);
            this.Kulüpler.Controls.Add(this.btnKulüpGuncelle);
            this.Kulüpler.Controls.Add(this.btnKulüpSil);
            this.Kulüpler.Controls.Add(this.btnKulüpKaydet);
            this.Kulüpler.Controls.Add(this.txtkulupAd);
            this.Kulüpler.Controls.Add(this.txtkulupId);
            this.Kulüpler.Controls.Add(this.label18);
            this.Kulüpler.Controls.Add(this.label19);
            this.Kulüpler.Location = new System.Drawing.Point(596, 0);
            this.Kulüpler.Name = "Kulüpler";
            this.Kulüpler.Size = new System.Drawing.Size(281, 220);
            this.Kulüpler.TabIndex = 2;
            this.Kulüpler.TabStop = false;
            this.Kulüpler.Text = "KULÜPLER";
            // 
            // btnKulüpListele
            // 
            this.btnKulüpListele.Location = new System.Drawing.Point(123, 105);
            this.btnKulüpListele.Name = "btnKulüpListele";
            this.btnKulüpListele.Size = new System.Drawing.Size(75, 23);
            this.btnKulüpListele.TabIndex = 17;
            this.btnKulüpListele.Text = "LİSTELE";
            this.btnKulüpListele.UseVisualStyleBackColor = true;
            this.btnKulüpListele.Click += new System.EventHandler(this.btnKulüpListele_Click);
            // 
            // btnKulüpGuncelle
            // 
            this.btnKulüpGuncelle.Location = new System.Drawing.Point(42, 105);
            this.btnKulüpGuncelle.Name = "btnKulüpGuncelle";
            this.btnKulüpGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnKulüpGuncelle.TabIndex = 16;
            this.btnKulüpGuncelle.Text = "GÜNCELLE";
            this.btnKulüpGuncelle.UseVisualStyleBackColor = true;
            this.btnKulüpGuncelle.Click += new System.EventHandler(this.btnKulüpGuncelle_Click);
            // 
            // btnKulüpSil
            // 
            this.btnKulüpSil.Location = new System.Drawing.Point(123, 76);
            this.btnKulüpSil.Name = "btnKulüpSil";
            this.btnKulüpSil.Size = new System.Drawing.Size(75, 23);
            this.btnKulüpSil.TabIndex = 15;
            this.btnKulüpSil.Text = "SİL";
            this.btnKulüpSil.UseVisualStyleBackColor = true;
            this.btnKulüpSil.Click += new System.EventHandler(this.btnKulüpSil_Click);
            // 
            // btnKulüpKaydet
            // 
            this.btnKulüpKaydet.Location = new System.Drawing.Point(42, 76);
            this.btnKulüpKaydet.Name = "btnKulüpKaydet";
            this.btnKulüpKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKulüpKaydet.TabIndex = 14;
            this.btnKulüpKaydet.Text = "KAYDET";
            this.btnKulüpKaydet.UseVisualStyleBackColor = true;
            this.btnKulüpKaydet.Click += new System.EventHandler(this.btnKulüpKaydet_Click);
            // 
            // txtkulupAd
            // 
            this.txtkulupAd.Location = new System.Drawing.Point(85, 43);
            this.txtkulupAd.Name = "txtkulupAd";
            this.txtkulupAd.Size = new System.Drawing.Size(156, 20);
            this.txtkulupAd.TabIndex = 6;
            // 
            // txtkulupId
            // 
            this.txtkulupId.Location = new System.Drawing.Point(85, 19);
            this.txtkulupId.Name = "txtkulupId";
            this.txtkulupId.Size = new System.Drawing.Size(156, 20);
            this.txtkulupId.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "KULÜPAD:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(58, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(1, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(876, 182);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 163);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(905, 415);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Kulüpler);
            this.Controls.Add(this.Notlar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Notlar.ResumeLayout(false);
            this.Notlar.PerformLayout();
            this.Kulüpler.ResumeLayout(false);
            this.Kulüpler.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cbKulüp;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Notlar;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtS3;
        private System.Windows.Forms.Button btnNotListele;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNotGuncelle;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtOgrId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox Kulüpler;
        private System.Windows.Forms.Button btnKulüpListele;
        private System.Windows.Forms.Button btnKulüpGuncelle;
        private System.Windows.Forms.Button btnKulüpSil;
        private System.Windows.Forms.Button btnKulüpKaydet;
        private System.Windows.Forms.TextBox txtkulupAd;
        private System.Windows.Forms.TextBox txtkulupId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHesapla;
    }
}

