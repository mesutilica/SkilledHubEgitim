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
            dgvUrunListesi.DataSource = productDal.GetAll(); // productDal nesnesi içerisinde yazdığımız GetAll() metodundan gelen ürün listesini çek ve ekrandaki dgvUrunListesi ne veri kaynağı olarak yolla.
        }
    }
}
