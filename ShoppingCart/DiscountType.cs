using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class DiscountType
    {
        public static IDiscount GetDiscountType(string discountType)
        {
            switch(discountType.ToLower())
            {
                case "fixed": return new FixedDiscount();
                case "configurable": return new ConfigurableDiscount();
                case "category":return new CategoryDiscount();
                default:return new FixedDiscount();

            }
        }
    }
}
