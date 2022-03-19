using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String.Tests
{
    /// <summary>NumberTests</summary>
    [TestClass()]
    public class NumberTests
    {
        private CheckNumber Number = new CheckNumber();

        /// <summary>
        /// Phones  number test1.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest1()
        {
            Assert.AreEqual(Number.PhoneNumber("+375443225611"), "+375443225611 - belarus");
        }

        /// <summary>
        /// Phones  number test2.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest2()
        {
            Assert.AreEqual(Number.PhoneNumber("+435443225611"), "+435443225611 - аustria");
        }

        /// <summary>
        /// Phones  number test3.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest3()
        {
            Assert.AreEqual(Number.PhoneNumber("+124643225611"), "+124643225611 - north_america");
        }

        /// <summary>
        /// Phones  number test4.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest4()
        {
            Assert.AreEqual(Number.PhoneNumber("+445443225611"), "+445443225611 - united_kingdom");
        }

        /// <summary>
        /// Phones  number test5.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest5()
        {
            Assert.AreEqual(Number.PhoneNumber("+395443225611"), "+395443225611 - italy");
        }

        /// <summary>
        /// Phones  number test6.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest6()
        {
            Assert.AreEqual(Number.PhoneNumber("+224443225611"), "+224443225611 - guinea");
        }

        /// <summary>
        /// Phones  number test7.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest7()
        {
            Assert.AreEqual(Number.PhoneNumber("+205443225611"), "+205443225611 - egypt");
        }

        /// <summary>
        /// Phones  number test8.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest8()
        {
            Assert.AreEqual(Number.PhoneNumber("+238443225611"), "+238443225611 - cape_verde");
        }

        /// <summary>
        /// Phones  number test9.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest9()
        {
            Assert.AreEqual(Number.PhoneNumber("+976443225611"), "+976443225611 - mongolia");
        }

        /// <summary>
        /// Phones  number test10.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest10()
        {
            Assert.AreEqual(Number.PhoneNumber("+815443225611"), "+815443225611 - japan");
        }

        /// <summary>
        /// Phones  number test11.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest11()
        {
            Assert.AreEqual(Number.PhoneNumber("+715443225611"), "+715443225611 - russia");
        }

        /// <summary>
        /// Phones  number test12.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest12()
        {
            Assert.AreEqual(Number.PhoneNumber("+535443225611"), "+535443225611 - cuba");
        }

        /// <summary>
        /// Phones  number test13.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest13()
        {
            Assert.AreEqual(Number.PhoneNumber("+692443225611"), "+692443225611 - marshall_islands");
        }

        /// <summary>
        /// Phones  number test14.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest14()
        {
            Assert.AreEqual(Number.PhoneNumber("+555443225611"), "+555443225611 - brazil");
        }

        /// <summary>
        /// Phones number test15.
        /// </summary>
        [TestMethod()]
        public void PhoneNumberTest15()
        {
            Assert.AreEqual(Number.PhoneNumber("+024243225611"), "");
        }

        /// <summary>Determines whether this instance is a number.</summary>
        [TestMethod()]
        public void IsInfo1()
        {
            Assert.AreEqual(Number.IsInfo("+124243225611"), true);
        }

        /// <summary>Determines whether this instance is  a number.</summary>
        [TestMethod()]
        public void IsInfo2()
        {
            Assert.AreEqual(Number.IsInfo("+12424"), false);
        }
    }
}