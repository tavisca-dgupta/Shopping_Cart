using System;
using Xunit;
using ShoppingCart;

namespace TestShopping
{
    public class TestMyCart
    {
        [Fact]
        public void Test_Add_Items_To_Cart()
        {
            Vendor admin = new Vendor();
            admin.AddProduct();
            MyCart cart = new MyCart("category");
            cart.AddItem("book", 2);
            cart.AddItem("mobile", 1);
            double value=cart.Checkout();
            Assert.Equal(8510, value);
        }

        [Fact]
        public void Test_Remove_Items_To_Cart()
        {
            Vendor admin = new Vendor();
            admin.AddProduct();
            MyCart cart = new MyCart("fixed");
            cart.AddItem("book", 2);
            cart.AddItem("mobile", 1);
            cart.RemoveItem("book", 1);
            double value = cart.Checkout();
            Assert.Equal(8755, value);
        }

        [Fact]
        public void Test_Get_Cart_Price_When_Category_Discount_Applied()
        {
            Vendor admin = new Vendor();
            admin.AddProduct();
            MyCart cart = new MyCart("category");
            cart.AddItem("mobile", 2);
            double value = cart.Checkout();
            Assert.Equal(16000, value);
        }

        [Fact]
        public void Test_Get_Cart_Price_When_Cart_Discount_Applied()
        {
            Vendor admin = new Vendor();
            admin.AddProduct();
            MyCart cart = new MyCart("fixed");
            cart.AddItem("book", 2);
            cart.AddItem("shirt", 1);
            double value = cart.Checkout();
            Assert.Equal(3060, value);
        }

        [Fact]
        public void Add_Product_That_is_Already_in_Cart()
        {
            Vendor admin = new Vendor();
            admin.AddProduct();
            MyCart cart = new MyCart("fixed");
            cart.AddItem("book", 2);
            cart.AddItem("T-shirt", 1);
            cart.AddItem("T-shirt", 2);
            Assert.Equal(3, MyCart.cartItems["T-shirt"]);

        }

        [Fact]
        public void Remove_Product_That_Is_Not_Present_in_Cart()
        {
            Vendor admin = new Vendor();
            admin.AddProduct();
            MyCart cart = new MyCart("fixed");
            cart.AddItem("book", 2);
            cart.AddItem("T-shirt", 1);
            Assert.False(cart.RemoveItem("TV", 1));
        }

        [Fact]
        public void Test_Cart_Price_If_Discount_is_Configurable()
        {
            Vendor admin = new Vendor();
            admin.AddProduct();
            MyCart cart = new MyCart("configurable");
            cart.AddItem("book", 2);
            cart.AddItem("T-shirt", 1);
            Assert.Equal(2080, cart.Checkout());
        }
    }
}
