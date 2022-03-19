using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Discount;
using System;

namespace Products.Tests
{
    /// <summary>
    /// PurchasesTests
    /// </summary>
    [TestClass()]
    public class PurchasesTests
    {
        /// <summary>
        /// The purchases
        /// </summary>
        Dicount dicount1 = new Dicount();

        Purchases purchases = new Purchases();

        /// <summary>
        /// Discounts for test.
        /// </summary>
        [TestMethod()]
        public void DiscountTest()
        {
            MyDiscount new_cost = new MyDiscount(100);
            purchases = new Socks("Носки", 100, new_cost);
            Assert.AreEqual(purchases.NewCost, 0);
        }

        /// <summary>
        /// Discounts for test1.
        /// </summary>
        [TestMethod()]
        public void DiscountTest1()
        {
            Dicount10 new_cost = new Dicount10();
            purchases = new Socks("Носки", 100, new_cost);
            Assert.AreEqual(purchases.NewCost, 90);
        }

        /// <summary>
        /// Discounts for test2.
        /// </summary>
        [TestMethod()]
        public void DiscountTest2()
        {
            Dicount25 new_cost = new Dicount25();
            purchases = new Socks("Носки", 100, new_cost);
            Assert.AreEqual(purchases.NewCost, 75);
        }

        /// <summary>Discounts the test3.</summary>
        [TestMethod()]
        public void DiscountTest3()
        {
            Exception expectedExcetpion = null;
            try { MyDiscount discount = new MyDiscount(Convert.ToInt32("f10")); Assert.AreEqual(purchases.NewCost, 10); }
            catch (Exception ex) { expectedExcetpion = ex; Assert.IsNotNull(expectedExcetpion); }
        }
    }
}