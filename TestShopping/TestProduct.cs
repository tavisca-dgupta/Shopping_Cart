using System;
using System.Linq;
using Xunit;
using ShoppingCart;

namespace TestShopping
{
    public class TestProduct
    {
        [Fact]
        public void Test_Setting_product_Name()
        {
            Product product = new Product("T-Shirt",1000,Category.categories.clothing);
            Assert.Equal("T-Shirt", product.name);
        }
        [Fact]
        public void Test_Setting_product_Price()
        {
            Product product = new Product("T-Shirt", 1000, Category.categories.clothing);
            Assert.Equal(1000, product.price);
        }
        [Fact]
        public void Test_Setting_product_Category()
        {
            Product product = new Product("T-Shirt", 1000, Category.categories.clothing);
            Assert.Equal(Category.categories.clothing, product.category);
        }
    }
}
