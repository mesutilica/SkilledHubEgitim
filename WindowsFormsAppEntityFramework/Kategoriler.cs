using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsAppAdoNet;

namespace WindowsFormsAppEntityFramework
{
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        UrunDbModel context = new UrunDbModel();
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        void Yukle()
        {
            dgvKategoriler.DataSource = context.Categories.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;

            txtKategoriAdi.Text = string.Empty;
            txtKategoriAciklamasi.Text = "";
            cbDurum.Checked = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category()
                {
                    Name = txtKategoriAdi.Text,
                    Description = txtKategoriAciklamasi.Text,
                    CreateDate = DateTime.Now,
                    Durum = cbDurum.Checked
                };
                context.Categories.Add(category);
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt Başarılı !");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız ! lütfen tüm alanları doldurunuz");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu !");
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value; // seçili satırdaki kaydın id sini yakaladık
            var kayit = context.Categories.Find(id); // id yi ef nin find metoduna verip eşleşen kategoriyi getirdik.

            #region Db den gelen kaydı ekrana doldur

            txtKategoriAdi.Text = kayit.Name;
            txtKategoriAciklamasi.Text = kayit.Description;
            cbDurum.Checked = kayit.Durum;

            #endregion

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value;
            var kayit = context.Categories.Find(id);

            kayit.Name = txtKategoriAdi.Text;
            kayit.Description = txtKategoriAciklamasi.Text;
            kayit.Durum = cbDurum.Checked;

            int sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                //dgvKategoriler.DataSource = context.Categories.ToList();
                Yukle();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız! lütfen tüm alanları doldurunuz");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dgvKategoriler.CurrentRow.Cells[0].Value;
            var kayit = context.Categories.Find(id);

            context.Categories.Remove(kayit);

            int sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                //dgvKategoriler.DataSource = context.Categories.ToList();
                Yukle();
                MessageBox.Show("Kayıt Silme Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız! lütfen tüm alanları doldurunuz");
            }
        }
    }
}
