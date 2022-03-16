using Proje1.Data;
using Proje1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class urunekle : Form
    {
        public urunekle()
        {
            InitializeComponent();
        }

        projeDbcontext projeDbcontext = new projeDbcontext();
        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                name = textBox3.Text,
                type = textBox4.Text,
                price = Convert.ToInt32(textBox5.Text),
                info = textBox1.Text,
                numberofStock =Convert.ToInt32(textBox2.Text)
            };
            projeDbcontext.Products.Add(product);
            int result = projeDbcontext.SaveChanges();
            string message = result > 0 ? "başarılı" : "başarısız";
        }

        void getProduct()
        {
            var product = projeDbcontext.Products.ToList();
            dataGridView1.DataSource = product;
        }

        private void urunekle_Load(object sender, EventArgs e)
        {
            getProduct();
        }
    }
}
