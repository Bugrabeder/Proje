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
    public partial class ulkekle : Form
    {
        public ulkekle()
        {
            InitializeComponent();
        }
        projeDbcontext projeDbcontext = new projeDbcontext();

        private void ulkekle_Load(object sender, EventArgs e)
        {
            getCountry();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Country country = new Country
            {
                name = textBox1.Text,
                info = textBox2.Text
            };
            projeDbcontext.Countrys.Add(country);
            int result = projeDbcontext.SaveChanges();
            string message = result > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(message);
        }
        void getCountry()
        {
            var country = projeDbcontext.Countrys.ToList();
            dataGridView1.DataSource = country;
        }
    }
}
