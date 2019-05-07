using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PR5webshopAPI.Models
{
    public class Order
    {
        public int ID { get; set; }

        public DateTime Orderdate { get; set; }

        public int CustomerID { get; set; }


       // public ICollection<Product> Producten { get; set; }
    }
}
