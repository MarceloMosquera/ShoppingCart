using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart.Domain;

namespace ShoppingCart.Test
{

    [TestClass]
    public class CartTest
    {

        private Cart _cart;

        [TestInitialize]
        public void Setup()
        {
            _cart = new Cart();
        }

        [TestMethod]
        public void ItemsVacio()
        {
            Assert.AreEqual(0, _cart.TotalAmount());
        }

        [TestMethod]
        public void ItemUnoPorUnidad()
        {
            _cart.Add(new OrderItem() { Quantity = 1, Sku = "U124AXLAF" });
            Assert.AreEqual(5.0m, _cart.TotalAmount());
        }

        [TestMethod]
        public void ItemConMedioKiloPeso()
        {
            _cart.Add(new OrderItem() { Quantity = 500, Sku = "P110SSLLF" });
            Assert.AreEqual(2m, _cart.TotalAmount());
        }

        [TestMethod]
        public void ItemDosEspecial()
        {
            _cart.Add(new OrderItem() { Quantity = 2, Sku = "E152AABAG" });
            Assert.AreEqual(2.80m, _cart.TotalAmount());
        }

        [TestMethod]
        public void ItemSeisEspacial()
        {
            _cart.Add(new OrderItem() { Quantity = 6, Sku = "E152AXLLA" });
            Assert.AreEqual(8m, _cart.TotalAmount());
        }

    }

}
