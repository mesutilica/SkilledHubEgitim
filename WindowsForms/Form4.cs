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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) // eğer textBox1 boş değilse
            {
                MessageBox.Show("Merhaba " + textBox1.Text); // MessageBox sınıfındaki Show metodu ekranda uyarı pencersi çıkartmamızı sağlar
            }
            else
            {
                MessageBox.Show("Lütfen Adınızı Giriniz!", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
