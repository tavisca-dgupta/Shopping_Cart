using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public interface IDiscount
    {
        double GetDiscount(Dictionary<string, int> items);
    }
}
