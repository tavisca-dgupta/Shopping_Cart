using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class MyCart
    {
        public static Dictionary<string, int> cartItems = new Dictionary<string, int>();
        ProductHandler itemDetails = new ProductHandler();
        FixedDiscount cartDiscount = new FixedDiscount();
        CategoryDiscount categoryDiscount = new CategoryDiscount();
        int cartValue = 0;
        string discountType;
        public MyCart(string discountType)
        {
            this.discountType = discountType;
        }

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
            if (cartItems.ContainsKey(itemName))
            {
                cartItems[itemName] -= itemQuantity;
            }
            else
                return false;

            int price = itemDetails.GetItemPriceByName(itemName);
            if(price!=-1)
            {
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

        public double Checkout()
        {
            IDiscount discount = DiscountType.GetDiscountType(discountType);
            
            return cartValue - discount.GetDiscount(cartItems); ;
        }

    }
}
