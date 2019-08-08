using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.com
{
    public class Admin
    {
        public void AddProduct()
        {
            Product item1 = new Product("mobile", 10000,Category.categories.entertainment);
            ProductHandler.items.Add(item1);
            Product item2 = new Product("shirt", 3000,Category.categories.clothing);
            ProductHandler.items.Add(item2);
            Product item3 = new Product("milk", 20,Category.categories.clothing);
            ProductHandler.items.Add(item3);
            Product item4 = new Product("book", 300,Category.categories.books);
            ProductHandler.items.Add(item4);

        }
    }
}
