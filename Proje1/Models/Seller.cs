using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Models
{
    class Seller
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public Country country { get; set; }
        public List<Product> products { get; set; }

        

    }
}
