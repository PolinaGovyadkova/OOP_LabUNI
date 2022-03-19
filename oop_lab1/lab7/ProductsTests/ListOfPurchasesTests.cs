using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Discount;
using System;

namespace Products.Tests
{
    /// <summary>
    /// ListOfPurchasesTests
    /// </summary>
    /// <seealso cref="Products.ListOfPurchases" />
    [TestClass()]
    public class ListOfPurchasesTests : ListOfPurchases
    {
        /// <summary>
        /// The purchases
        /// </summary>
        Purchases purchases = new Purchases();

        /// <summary>
        /// All cost by type.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public override string AllCostByType(string name)
        {
            double all_cost = 0;
            double all_cost_with_discount = 0;
            int count = 0;
            Dicount10 new_cost = new Dicount10();
            Dicount25 new_cost1 = new Dicount25();
            Purchases[] new_purchases = new Purchases[] { new Socks("Носки", 100, new_cost), new Jacket("Куртка", 200, new_cost1), new Socks("Носки", 550, new_cost)
            , new Socks("Носки", 100.500, new_cost), new Top("Топ", 1000, new_cost1), new Socks("Носки", 50, new_cost) };
            for (int i = 0; i < new_purchases.Length; i++)
            {
                if (new_purchases[i].Name == name)
                {
                    count++;
                    all_cost += new_purchases[i].Cost;
                    all_cost_with_discount += new_purchases[i].NewCost;
                }
            }
            if (count != 0)
            {
                all_cost /= count;
                all_cost_with_discount /= count;
            }
            else all_cost = 0;
            return "Цена без скидки: " + Convert.ToString(all_cost) + "\nЦена со скидкой: " + Convert.ToString(all_cost_with_discount);
        }

        /// <summary>
        /// All cost by type test.
        /// </summary>
        [TestMethod()]
        public void AllCostByTypeTest()
        {
            string str = "Цена без скидки: " + Convert.ToString(200.125) + "\nЦена со скидкой: " + Convert.ToString(180.1125);
            Assert.AreEqual(AllCostByType("Носки"), str);
        }

        /// <summary>
        /// All count by type.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public override string AllCountByType(string name)
        {
            string[] new_purchases = new string[] { "Ботинки", "Шапка", "Ботинки", "Куртка", "Ботинки", "Худи" };
            int count = 0;
            for (int i = 0; i < new_purchases.Length; i++)
            {
                if (new_purchases[i] == name)
                {
                    count++;
                }
            }
            return Convert.ToString(count);
        }

        /// <summary>
        /// All count by type test.
        /// </summary>
        [TestMethod()]
        public void AllCountByTypeTest()
        {
            Assert.AreEqual(AllCountByType("Ботинки"), "3");
        }

        /// <summary>
        /// Total cost.
        /// </summary>
        /// <returns></returns>
        public override string TotalCost()
        {
            Dicount10 new_cost = new Dicount10();
            Dicount25 new_cost1 = new Dicount25();
            Purchases[] new_purchases = new Purchases[] { new Socks("Носки", 100, new_cost), new Socks("Носки", 200, new_cost1), new Socks("Носки", 550, new_cost)
            , new Socks("Носки", 100.500, new_cost), new Socks("Носки", 1000, new_cost1), new Socks("Носки", 50, new_cost) };
            double all_cost_with_discount = 0;
            double all_cost = 0;
            for (int i = 0; i < new_purchases.Length; i++)
            {
                all_cost_with_discount += new_purchases[i].NewCost;
                all_cost += new_purchases[i].Cost;
            }
            return "Цена без скидки: " + Convert.ToString(all_cost) + "\nЦена со скидкой: " + Convert.ToString(all_cost_with_discount);
        }

        /// <summary>
        /// Total cost test.
        /// </summary>
        [TestMethod()]
        public void TotalCostTest()
        {
            string str = "";
            Exception expectedExcetpion = null;
            try
            {
                str = "Цена без скидки: " + Convert.ToString("ffff") + "\nЦена со скидкой: " + Convert.ToString(1620.45);
                Assert.AreEqual(TotalCost(), str);
            }
            catch (Exception ex) { expectedExcetpion = ex; Assert.IsNotNull(expectedExcetpion); }
        }

        /// <summary>
        /// Submitted units.
        /// </summary>
        /// <returns></returns>
        public virtual string SubmittedUnits()
        {
            int count = 0;
            string[] new_purchases = new string[] { "Ботинки", "Шапка", "Ботинки", "Куртка", "Ботинки", "Худи" };
            int[] percent = new int[] { 10, 25, 53, 0, 0, 0 };
            for (int i = 0; i < new_purchases.Length; i++)
            {
                if (percent[i] != 0)
                {
                    count++;
                }
            }
            return Convert.ToString(count);
        }

        /// <summary>
        /// Submitted units test.
        /// </summary>
        [TestMethod()]
        public void SubmittedUnitsTest()
        {
            Assert.AreEqual(SubmittedUnits(), "3");
        }
    }
}