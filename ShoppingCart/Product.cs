using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public string name { get; set; }
        public int price { get; set; }

        public Category.categories category;
        public Product(string name, int price,Category.categories category)
        {
            this.name = name;
            this.price = price;
            this.category = category;

        }
    }
}
