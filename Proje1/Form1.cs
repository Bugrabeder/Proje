using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje1.Data;

namespace Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        projeDbcontext ProjeDbcontext = new projeDbcontext();

        private void Form1_Load(object sender, EventArgs e)
        {
            ProjeDbcontext.Database.EnsureCreated();
            var allcontext = ProjeDbcontext.Products;
            var data = allcontext.Select(f => new
            {
                Id = f.id,
                Name = f.name,
                type = f.type,
                price = f.price,
                numberofstock = f.numberofStock,
            });
            var list = data.ToList();
            dataGridView1.DataSource = list;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            urunekle urunekle = new urunekle();
            urunekle.Show();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            ulkekle ulkekle = new ulkekle();
            ulkekle.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saticiekle saticiekle = new saticiekle();
            saticiekle.Show();
        }
     
    }
}
