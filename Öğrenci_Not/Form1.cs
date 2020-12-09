using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESSLOGICLAYER;
using ENTITYLAYER;
using FACADELAYERR;

namespace Öğrenci_Not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void OgrenciListesi()
        {
            List<ENTITYOGRENCI> OgrList = BLLOGRENCI.LISTELE();

            dataGridView1.DataSource = OgrList;

            this.Text = "Öğrenci Listesi";
        }

        void NotListesi()
        {
            List<ENTITYNOTLAR> EntNot = BLLNOTLAR.LISTELE();
            dataGridView1.DataSource = EntNot;
            this.Text = "Not Listesi";
        }

        void KulupListesi()
        {
            List<ENTITYKULUP> KlpLst = BLLKULUP.LISTELE();
            cbKulüp.DisplayMember = "KULUPAD";
            cbKulüp.ValueMember = "KULUPID";
            cbKulüp.DataSource = KlpLst;
            dataGridView1.DataSource = KlpLst;
            this.Text = "Kulüp Listesi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciListesi();
            KulupListesi();
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ENTITYOGRENCI ent = new ENTITYOGRENCI();
            ent.AD = txtAd.Text;
            ent.SOYAD = txtSoyad.Text;
            ent.FOTOGRAF = txtFoto.Text;
            ent.KULUPID = Convert.ToInt16(cbKulüp.SelectedValue);
            BLLOGRENCI.EKLE(ent);
            MessageBox.Show("Öğrenci Kayıt İşlemi Tamamlandı");
            OgrenciListesi();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ENTITYOGRENCI ent = new ENTITYOGRENCI();
            ent.AD = txtAd.Text;
            ent.SOYAD = txtSoyad.Text;
            ent.FOTOGRAF = txtFoto.Text;
            ent.KULUPID = Convert.ToInt16(cbKulüp.SelectedValue);
            ent.ID = Convert.ToInt16(txtID.Text);
            BLLOGRENCI.GUNCELLE(ent);
            MessageBox.Show("Öğrenci Güncelleme İşlemi Tamamlandı");
            OgrenciListesi();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            OgrenciListesi();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                if (this.Text == "Öğrenci Listesi")

                {

                    int secilen = dataGridView1.SelectedCells[0].RowIndex;

                    txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

                    txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

                    txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

                    txtFoto.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                }

                if(this.Text=="Not Listesi")
                {
                    int secilen=dataGridView1.SelectedCells[0].RowIndex;
                    txtOgrId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                    txtAd.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
                    txtSoyad.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
                    txtS1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                    txtS2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                    txtS3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                    txtProje.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                    txtOrt.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                    txtDurum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                }
            }
        }

        private void btnNotListele_Click(object sender, EventArgs e)
        {
            NotListesi();
        }

        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            ENTITYNOTLAR ent = new ENTITYNOTLAR();
            ent.OGRENCIID = Convert.ToInt16(txtOgrId.Text);
            ent.SINAV1 = Convert.ToInt16(txtS1.Text);
            ent.SINAV2 = Convert.ToInt16(txtS2.Text);
            ent.SINAV3 = Convert.ToInt16(txtS3.Text);
            ent.PROJE = Convert.ToInt16(txtProje.Text);
            ent.ORTALAMA = Convert.ToInt16(txtOrt.Text);
            ent.DURUM =(txtDurum.Text);
            BLLNOTLAR.GUNCELLE(ent);
            MessageBox.Show("Not Güncelleme İşlemi Tamamlandı");
            NotListesi();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, proje;
            double ortalama;
            string durum;

            s1 = Convert.ToInt16(txtS1.Text);
            s2 = Convert.ToInt16(txtS2.Text);
            s3 = Convert.ToInt16(txtS3.Text);
            proje = Convert.ToInt16(txtProje.Text);

            ortalama = (s1 + s2 + s3 + proje) / 4;
            txtOrt.Text = ortalama.ToString();
            if (ortalama >=50)
            {
                durum = "True";

            }
            else
            {
                durum = "False";
            }
            txtDurum.Text = durum;
;        }

        private void btnKulüpListele_Click(object sender, EventArgs e)
        {
            KulupListesi();
        }

        private void btnKulüpKaydet_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent = new ENTITYKULUP();
            ent.KULUPAD = txtkulupAd.Text;
            BLLKULUP.EKLE(ent);
            KulupListesi();
        }

        private void btnKulüpSil_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent = new ENTITYKULUP();
            ent.KULUPID = Convert.ToInt16(txtkulupId.Text);
            BLLKULUP.SIL(ent.KULUPID);
            KulupListesi();
        }

        private void btnKulüpGuncelle_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent = new ENTITYKULUP();
            ent.KULUPAD = txtkulupAd.Text;
            ent.KULUPID = Convert.ToInt16(txtkulupId.Text);
            BLLKULUP.GUNCELLE(ent);
            KulupListesi();
        }
    }
}
