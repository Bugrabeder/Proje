using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Models
{
    class Order
    {
        public int id { get; set; }
        public List<Product> products { get; set; }

        public int productId { get; set; }
        public int price { get; set; }
        public DateTime creatingDate { get; set; }

        public int customerId { get; set; }
        public Customer customer { get; set; }

    }
}
