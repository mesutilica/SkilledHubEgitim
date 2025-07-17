using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppAdoNet;

namespace WindowsFormsAppEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunDbModel context = new UrunDbModel();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUrunListesi.DataSource = context.Products.ToList(); // Entity framework ile veritabanındaki ürünleri çekme
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var urun = new Product
                {
                    UrunAdi = txtUrunAdi.Text,
                    StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                    UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
                    Durum = cbDurum.Checked
                };
                context.Products.Add(urun); // context nesnesindeki products tablosuna ürünü ekle
                int sonuc = context.SaveChanges(); // context deki değişiklikleri veritabanına yansıt
                if (sonuc > 0)
                {
                    dgvUrunListesi.DataSource = context.Products.ToList();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!");
            }
        }

        private void dgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgvUrunListesi.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyati.Text = dgvUrunListesi.CurrentRow.Cells[2].Value.ToString();
            txtStokMiktari.Text = dgvUrunListesi.CurrentRow.Cells[3].Value.ToString();
            cbDurum.Checked = (bool)dgvUrunListesi.CurrentRow.Cells[4].Value;

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var urun = new Product
                {
                    Id = (int)dgvUrunListesi.CurrentRow.Cells[0].Value,
                    UrunAdi = txtUrunAdi.Text,
                    StokMiktari = Convert.ToInt32(txtStokMiktari.Text),
                    UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text),
                    Durum = cbDurum.Checked
                };
                var product = context.Entry(urun); // context nesnesindeki products tablosuna eklenecek ürünü yakala ve product nesnesine ata
                product.State = System.Data.Entity.EntityState.Modified; // product nesnesinin durumunu Modified-değiştirildi olarak işaretle
                int sonuc = context.SaveChanges(); // context deki değişiklikleri veritabanına yansıt
                if (sonuc > 0)
                {
                    dgvUrunListesi.DataSource = context.Products.ToList();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!" + hata.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var product = context.Products.Find((int)dgvUrunListesi.CurrentRow.Cells[0].Value);

                    context.Products.Remove(product);

                    int sonuc = context.SaveChanges();
                    if (sonuc > 0)
                    {
                        dgvUrunListesi.DataSource = context.Products.ToList();
                        btnEkle.Enabled = true;
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;
                        MessageBox.Show("Kayıt Silindi!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata Oluştu!");
                }
            }
        }
    }
}
