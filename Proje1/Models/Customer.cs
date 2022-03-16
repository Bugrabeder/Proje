using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Models
{
    class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string mail { get; set; }
        public int age { get; set; }
        public DateTime createdDate { get; set; }
        public Country country { get; set; }
        
        public List<Order> orders { get; set; }

        public int orderid { get; set; }



    }
}
