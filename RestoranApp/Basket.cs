using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranApp
{
    public class Basket
    {
        public List<ProductOfBasket> products { get; set; }

        public Basket()
        {
            products = new List<ProductOfBasket>();
        }
    }
    public class ProductOfBasket
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public byte count { get; set; }
        public decimal totalPrice { get; set; }
        public int id { get; set; }
        public Category category { get; set; }
    }
}
