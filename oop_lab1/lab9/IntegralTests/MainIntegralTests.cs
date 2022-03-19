using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Integral.Tests
{
    /// <summary>
    /// MainIntegralTests
    /// </summary>
    [TestClass()]
    public class MainIntegralTests
    {
        /// <summary>
        /// Converts the log test1.
        /// </summary>
        [TestMethod()]
        public void ConvertLogTest1()
        {
            MainIntegral mainIntegral1 = new MainIntegral(1, 1);
            Exception expectedExcetpion = null;
            try { Assert.AreEqual(MainIntegral.ConvertCos("fggf", "gfgf"), mainIntegral1); }
            catch (Exception ex) { expectedExcetpion = ex; Assert.IsNotNull(expectedExcetpion); }
        }

        /// <summary>
        /// Converts the log test.
        /// </summary>
        [TestMethod()]
        public void ConvertLogTest()
        {
            MainIntegral mainIntegral1 = new MainIntegral(1, 1);
            Exception expectedExcetpion = null;
            try { Assert.AreEqual(MainIntegral.ConvertQuad("fggf", "gfgf"), mainIntegral1); }
            catch (Exception ex) { expectedExcetpion = ex; Assert.IsNotNull(expectedExcetpion); }
        }

        /// <summary>
        /// Converts the log test2.
        /// </summary>
        [TestMethod()]
        public void ConvertLogTest2()
        {
            MainIntegral mainIntegral1 = new MainIntegral(1, 1);
            Exception expectedExcetpion = null;
            try { Assert.AreEqual(MainIntegral.ConvertLog("fggf", "gfgf"), mainIntegral1); }
            catch (Exception ex) { expectedExcetpion = ex; Assert.IsNotNull(expectedExcetpion); }
        }

        /// <summary>
        /// Integrals the log.
        /// </summary>
        [TestMethod()]
        public void IntegralLog()
        {
            MainIntegral integral = new IntegralLog(1, 1);
            Assert.AreEqual(6 * integral, 0, 0);
        }

        /// <summary>
        /// Integrals the log2.
        /// </summary>
        [TestMethod()]
        public void IntegralLog2()
        {
            MainIntegral integralLog = new IntegralLog(1, 1);
            MainIntegral integralCos = new IntegralLog(5, 8);
            Assert.AreEqual(integralCos + integralLog, 2.42, 0.055);
        }

        /// <summary>
        /// Integrals the log1.
        /// </summary>
        [TestMethod()]
        public void IntegralLog1()
        {
            Exception expectedExcetpion = null;
            try
            {
                MainIntegral integral = new IntegralLog(Convert.ToInt32("f"), 1);
                Assert.AreEqual(6 * integral, 0, 0);
            }
            catch (Exception ex) { expectedExcetpion = ex; Assert.IsNotNull(expectedExcetpion); }
        }

        /// <summary>
        /// Integrals the cos.
        /// </summary>
        [TestMethod()]
        public void IntegralCos()
        {
            IntegralCos integral = new IntegralCos(2, 2);
            Assert.AreEqual(0 * integral, 0, 0);
        }

        /// <summary>
        /// Integrals the cos2.
        /// </summary>
        [TestMethod()]
        public void IntegralCos2()
        {
            IntegralCos integral = new IntegralCos(1, 2);
            IntegralQuad integral1 = new IntegralQuad(1, 2);
            Assert.AreEqual(integral1 + integral, 2.4, 0.05);
        }

        /// <summary>
        /// Integrals the cos1.
        /// </summary>
        [TestMethod()]
        public void IntegralCos1()
        {
            Exception expectedExcetpion = null;
            try
            {
                IntegralCos integral = new IntegralCos(Convert.ToInt32("f"), 1);
                Assert.AreEqual(6 * integral, 0, 0);
            }
            catch (Exception ex) { expectedExcetpion = ex; Assert.IsNotNull(expectedExcetpion); }
        }

        /// <summary>
        /// Integrals the quad.
        /// </summary>
        [TestMethod()]
        public void IntegralQuad()
        {
            IntegralQuad integral = new IntegralQuad(2, 2);
            Assert.AreEqual(0 * integral, 0, 0);
        }

        /// <summary>
        /// Integrals the quad2.
        /// </summary>
        [TestMethod()]
        public void IntegralQuad2()
        {
            IntegralQuad integral = new IntegralQuad(1, 2);
            IntegralQuad integral1 = new IntegralQuad(1, 2);
            Assert.AreEqual(integral1 + integral, 4.6, 0.07);
        }

        /// <summary>
        /// Integrals the quad1.
        /// </summary>
        [TestMethod()]
        public void IntegralQuad1()
        {
            Exception expectedExcetpion = null;
            try
            {
                IntegralQuad integral = new IntegralQuad(Convert.ToInt32("f"), 1);
                Assert.AreEqual(6 * integral, 0, 0);
            }
            catch (Exception ex) { expectedExcetpion = ex; Assert.IsNotNull(expectedExcetpion); }
        }
    }
}