using System;
using System.Linq;
using Xunit;
using Shopping.com;

namespace TestShopping
{
    public class TestProductHandler
    {
        [Fact]
        public void Add_Product_To_Product_List()
        {
            ProductHandler handler = new ProductHandler();
            handler.AddProduct("TV", 3000, Category.categories.entertainment);
            Assert.Equal(Category.categories.entertainment, handler.GetItemCategoryByName("TV"));
        }
        [Fact]
        public void Get_Item_Price_Using_Name()
        {
            ProductHandler handler = new ProductHandler();
            handler.AddProduct("TV", 3000, Category.categories.entertainment);
            Assert.Equal(3000, handler.GetItemPriceByName("TV"));
        }
        [Fact]
        public void Get_Item_Category_By_Name()
        {
            ProductHandler handler = new ProductHandler();
            handler.AddProduct("curd", 20, Category.categories.dairy);
            Assert.Equal(Category.categories.dairy, handler.GetItemCategoryByName("curd"));
        }



    }
}
