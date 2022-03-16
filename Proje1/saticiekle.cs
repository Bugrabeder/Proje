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
    public partial class saticiekle : Form
    {
        public saticiekle()
        {
            InitializeComponent();
        }

        projeDbcontext projeDbcontext = new projeDbcontext();
        private void button1_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller
            {
                name = textBox1.Text,
                lastName = textBox2.Text,
            };
            projeDbcontext.Sellers.Add(seller);
            int result = projeDbcontext.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(message);
        }
        void getDirectors()
        {
            var sellers = projeDbcontext.Sellers.ToList();
            dataGridView1.DataSource = sellers;
        }

        private void saticiekle_Load(object sender, EventArgs e)
        {
            getDirectors();
        }
    }
}
