using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CategoryDiscount:IDiscount
    {
        ProductHandler productHandler = new ProductHandler();
        public int DiscountValue(Category.categories category)
        {
            switch(category)
            {
                case Category.categories.books:return 15;
                case Category.categories.dairy: return 5;
                case Category.categories.entertainment:return 20;
                case Category.categories.clothing:return 10;
                default: return 0;
            }
        }

        public double GetDiscount(Dictionary<string, int> items)
        {
            double discount = 0;
            for(int i=0;i<items.Count;i++)
            {
                var item = items.ElementAt(i);
                Category.categories category = productHandler.GetItemCategoryByName(item.Key);
                int price = productHandler.GetItemPriceByName(item.Key);
                discount = discount + (price * item.Value * DiscountValue(category) / 100);
            }
            return discount;
        }
    }
}
