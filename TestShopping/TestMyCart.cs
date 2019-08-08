using System;
using Xunit;
using Shopping.com;

namespace TestShopping
{
    public class TestMyCart
    {
        [Fact]
        public void Test_Add_Items_To_Cart()
        {
            Admin admin = new Admin();
            admin.AddProduct();
            MyCart cart = new MyCart();
            cart.AddItem("book", 2);
            cart.AddItem("mobile", 1);
            int value=cart.GetCartValue();
            Assert.Equal(8510, value);
        }

        [Fact]
        public void Test_Remove_Items_To_Cart()
        {
            Admin admin = new Admin();
            admin.AddProduct();
            MyCart cart = new MyCart();
            cart.AddItem("book", 2);
            cart.AddItem("mobile", 1);
            cart.RemoveItem("book", 1);
            int value = cart.GetCartValue();
            Assert.Equal(8255, value);
        }

        [Fact]
        public void Test_Get_Cart_Price_When_Category_Discount_Applied()
        {
            Admin admin = new Admin();
            admin.AddProduct();
            MyCart cart = new MyCart();
            cart.AddItem("mobile", 2);
            int value = cart.GetCartValue();
            Assert.Equal(16000, value);
        }

        [Fact]
        public void Test_Get_Cart_Price_When_Cart_Discount_Applied()
        {
            Admin admin = new Admin();
            admin.AddProduct();
            MyCart cart = new MyCart();
            cart.AddItem("book", 2);
            cart.AddItem("shirt", 1);
            int value = cart.GetCartValue();
            Assert.Equal(3060, value);
        }
    }
}
