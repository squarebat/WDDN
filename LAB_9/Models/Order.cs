using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
