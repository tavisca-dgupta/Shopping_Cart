using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ProductHandler
    {
        public static List<Product> items = new List<Product>();
        public Product product;

        public void AddProduct(string name,int price,Category.categories category)
        {
            product = new Product(name, price,category);
            items.Add(product);
        }

        public int GetItemPriceByName(string name)
        {
            foreach(Product item in items)
            {
                if(item.name.Equals(name))
                {
                    product = item;
                    return item.price;
                }
            }
            return -1;
        }

        public Category.categories GetItemCategoryByName(string name)
        {
            foreach (Product item in items)
            {
                if (item.name.Equals(name))
                {
                    return item.category;
                }
            }
            return Category.categories.books;
        }
    }
}
