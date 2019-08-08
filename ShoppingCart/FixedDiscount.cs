using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart
{
    public class FixedDiscount:IDiscount
    {
        ProductHandler productHandler = new ProductHandler();
        public int DiscountValue(int cartValue)
        {
            if (cartValue <= 1000)
            {
                return 5;
            }
            else if (cartValue <= 2000)
            {
                return 10;
            }
            else 
            {
                return 15;
            }
            
        }

        public double GetDiscount(Dictionary<string, int> items)
        {
            int totalPrice = 0;
            for (int i = 0; i < items.Count; i++)
            {
                var item = items.ElementAt(i);
                totalPrice = totalPrice + (productHandler.GetItemPriceByName(item.Key)*item.Value);
            }
            return totalPrice * DiscountValue(totalPrice) /100;
        }
    }
}
