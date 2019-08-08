using System;
using System.Linq;
using Xunit;
using ShoppingCart;

namespace TestShopping
{
    public class TestCategoryDiscount
    {
        [Fact]
        public void Test_DisCount_When_Category_is_Clothing()
        {
            CategoryDiscount categoryDiscount = new CategoryDiscount();
            Assert.Equal(10, categoryDiscount.DiscountValue(Category.categories.clothing));
        }
        [Fact]
        public void Test_DisCount_When_Category_is_Entertainment()
        {
            CategoryDiscount categoryDiscount = new CategoryDiscount();
            Assert.Equal(20, categoryDiscount.DiscountValue(Category.categories.entertainment));
        }
        [Fact]
        public void Test_DisCount_When_Category_is_Dairy()
        {
            CategoryDiscount categoryDiscount = new CategoryDiscount();
            Assert.Equal(5, categoryDiscount.DiscountValue(Category.categories.dairy));
        }
        [Fact]
        public void Test_DisCount_When_Category_is_Books()
        {
            CategoryDiscount categoryDiscount = new CategoryDiscount();
            Assert.Equal(15, categoryDiscount.DiscountValue(Category.categories.books));
        }
    }
}
