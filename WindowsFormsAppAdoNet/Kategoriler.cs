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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        KategoriDAL kategoriDAL = new KategoriDAL();
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = kategoriDAL.GetDataTable("select * from Kategoriler");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var kategori = new Category()
                {
                    Name = txtKategoriAdi.Text,
                    Description = txtKategoriAciklamasi.Text,
                    CreateDate = DateTime.Now,
                    Durum = cbDurum.Checked
                };
                var sonuc = kategoriDAL.Add(kategori);
                if (sonuc > 0)
                {
                    dgvKategoriler.DataSource = kategoriDAL.GetDataTable("select * from Kategoriler");
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            txtKategoriAciklamasi.Text = dgvKategoriler.CurrentRow.Cells[2].Value.ToString();
            cbDurum.Checked = Convert.ToBoolean(dgvKategoriler.CurrentRow.Cells[3].Value);

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var kategori = new Category()
                {
                    Id = (int)dgvKategoriler.CurrentRow.Cells[0].Value,
                    Name = txtKategoriAdi.Text,
                    Description = txtKategoriAciklamasi.Text,
                    CreateDate = (DateTime)dgvKategoriler.CurrentRow.Cells[4].Value,
                    Durum = cbDurum.Checked
                };
                var sonuc = kategoriDAL.Update(kategori);
                if (sonuc > 0)
                {
                    dgvKategoriler.DataSource = kategoriDAL.GetDataTable("select * from Kategoriler");
                    btnEkle.Enabled = true;
                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = false;
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int sonuc = kategoriDAL.Delete((int)dgvKategoriler.CurrentRow.Cells[0].Value);
                    if (sonuc > 0)
                    {
                        dgvKategoriler.DataSource = kategoriDAL.GetDataTable("select * from kategoriler");
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
