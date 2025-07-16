using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            // dgvUrunListesi.DataSource = productDal.GetAll(); // productDal nesnesi içerisinde yazdığımız GetAll() metodundan gelen ürün listesini çek ve ekrandaki dgvUrunListesi ne veri kaynağı olarak yolla.
            dgvUrunListesi.DataSource = productDal.GetDataTable("select * from Urunler");
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
                int sonuc = productDal.Add(urun);
                if (sonuc > 0)
                {
                    dgvUrunListesi.DataSource = productDal.GetAll();
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
                int sonuc = productDal.Update(urun);
                if (sonuc > 0)
                {
                    dgvUrunListesi.DataSource = productDal.GetAll();
                    btnEkle.Enabled = true;
                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = false;
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int sonuc = productDal.Delete((int)dgvUrunListesi.CurrentRow.Cells[0].Value);
                    if (sonuc > 0)
                    {
                        dgvUrunListesi.DataSource = productDal.GetAll();
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
