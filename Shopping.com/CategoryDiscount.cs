using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.com
{
    public class CategoryDiscount
    {
        public int GetDiscount(Category.categories category)
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

    }
}
