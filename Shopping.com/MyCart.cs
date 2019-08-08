using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.com
{
    public class MyCart
    {
        Dictionary<string, int> cartItems = new Dictionary<string, int>();
        ProductHandler itemDetails = new ProductHandler();
        CartDiscount cartDiscount = new CartDiscount();
        CategoryDiscount categoryDiscount = new CategoryDiscount();
        int categoryWiseDiscount = 0;
        int cartValue = 0;
        public bool AddItem(string itemName,int itemQuantity)
        {
            if(cartItems.ContainsKey(itemName))
            {
                cartItems[itemName] += itemQuantity;
            }
            else
                cartItems.Add(itemName, itemQuantity);

            int price = itemDetails.GetItemPriceByName(itemName);
            if(price!=-1)
            {
                int discount = categoryDiscount.GetDiscount(itemDetails.product.category);
                categoryWiseDiscount = categoryWiseDiscount + (price * itemQuantity* discount / 100);
                cartValue = cartValue + (price* itemQuantity);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool RemoveItem(string itemName,int itemQuantity)
        {
            int price = itemDetails.GetItemPriceByName(itemName);
            if(price!=-1)
            {
                int discount = categoryDiscount.GetDiscount(itemDetails.product.category);
                categoryWiseDiscount = categoryWiseDiscount - (price * itemQuantity * discount / 100);
                cartValue = cartValue - (price * itemQuantity);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> GetCartItem()
        {
            List<string> items = new List<string>();
            for(int i=0;i<cartItems.Count;i++)
            {
                var item = cartItems.ElementAt(i);
                items.Add(item.Key);
            }
            return items;
        }

        public int GetCartValue()
        {
            int cartWiseDiscount = (cartValue * cartDiscount.GetDiscount(cartValue) / 100 );
            if (cartWiseDiscount >= categoryWiseDiscount)
                return cartValue - cartWiseDiscount;

            else
                return cartValue - categoryWiseDiscount;
        }

    }
}
