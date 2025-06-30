using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ekrandaki form yüklendiğinde bu metot çalışır, veritabanından veri çekip ekrana gönderme gibi işlemleri burada yapabiliriz.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            // form2.Show(); //Çağırılan form Show metoduyla gösterilirse, tüm formlara erişim sağlanabilir
            form2.ShowDialog(); //Çağırılan form ShowDialog metoduyla gösterilirse, üstteki form kapatılana kadar alttaki forma erişim engellenir
            // this.Hide(); // form 2 yi açtıktan sonra bu formu (form 1) gizle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this.Close(); // formu kapat
            Application.Exit(); // uygulmayı kapat
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.AdSoyad = txtAdSoyad.Text;
            form2.ShowDialog();
        }
    }
}
