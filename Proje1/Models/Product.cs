using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Models
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dateAdded { get; set; }
        public string type { get; set; }
        public int price { get; set; }
        public string info { get; set; }
        public int numberofStock { get; set; }
        public List<Order> orders { get; set; }
        public Seller seller { get; set; }


    }
}
