using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Integral.Tests
{
    /// <summary>
    /// Tests
    /// </summary>
    [TestClass()]
    public class IntegralTests
    {
        /// <summary>
        /// Multiplications for cos test1.
        /// </summary>
        [TestMethod()]
        public void MultiplicationForCosTest1()
        {
            Function integral = new Function(-1, 2);
            Assert.AreEqual(integral.MultiplicationForCos(6, -1, 2), 10.513, 0.513);
        }

        /// <summary>
        /// Multiplications for log test2.
        /// </summary>
        [TestMethod()]
        public void MultiplicationForLogTest2()
        {
            Function integral = new Function(3, 6);
            Assert.AreEqual(integral.MultiplicationForLog(-3, 3, 6), -5.802, 0.8026);
        }

        /// <summary>
        /// Multiplications the forl quad test3.
        /// </summary>
        [TestMethod()]
        public void MultiplicationForlQuadTest3()
        {
            Function integral = new Function(3, 6);
            Assert.AreEqual(integral.MultiplicationForlQuad(7, 3, 6), 440.72, 0.006);
        }

        /// <summary>
        /// Sums for cos and log test4.
        /// </summary>
        [TestMethod()]
        public void SumForCosAndLogTest4()
        {
            Function integral = new Function(1, 3);
            Assert.AreEqual(integral.SumForCosAndLog(1, 3), -0.13652, 0.00052);
        }

        /// <summary>
        /// Sums for cos and quad test5.
        /// </summary>
        [TestMethod()]
        public void SumForCosAndQuadTest5()
        {
            Function integral = new Function(-3, 6);
            Assert.AreEqual(integral.SumForCosAndQuad(-3, 6), 80.731, 0.0015);
        }

        /// <summary>
        /// Sums for log and quad test6.
        /// </summary>
        [TestMethod()]
        public void SumForLogAndQuadTest6()
        {
            Function integral = new Function(3, 10);
            Assert.AreEqual(integral.SumForLogAndQuad(3, 10), 329.542, 0.0006);
        }

        /// <summary>
        /// Cos the test7.
        /// </summary>
        [TestMethod()]
        public void CosTest7()
        {
            IntegralCos cos = new IntegralCos(-11.0, 4.0);
            Assert.AreEqual(cos.Solve(), -1.75, 0.002);
        }

        /// <summary>
        /// Log the test8.
        /// </summary>
        [TestMethod()]
        public void LogTest8()
        {
            IntegralLog log = new IntegralLog(0.1, 8.0);
            Assert.AreEqual(log.Solve(), 3.886, 0.0003);
        }

        /// <summary>
        /// Quadl the test9.
        /// </summary>
        [TestMethod()]
        public void QuadlTest9()
        {
            IntegralQuad quad = new IntegralQuad(-9, -1);
            Assert.AreEqual(quad.Solve(), 242.986, 0.0008);
        }

        /// <summary>
        /// Cos the test10.
        /// </summary>
        [TestMethod()]
        public void CosTest10()
        {
            IntegralCos cos = new IntegralCos(-1.0, -1.0);
            Assert.AreEqual(cos.Solve(), 0, 0);
        }

        /// <summary>
        /// Log the test11.
        /// </summary>
        [TestMethod()]
        public void LogTest11()
        {
            IntegralLog log = new IntegralLog(1.1, 1.1);
            Assert.AreEqual(log.Solve(), 0, 0);
        }

        /// <summary>
        /// Quad the test12.
        /// </summary>
        [TestMethod()]
        public void QuadTest12()
        {
            IntegralQuad quad = new IntegralQuad(4, 4);
            Assert.AreEqual(quad.Solve(), 0, 0);
        }

        /// <summary>
        /// Cos the test13.
        /// </summary>
        [TestMethod()]
        public void CosTest13()
        {
            IntegralCos cos = new IntegralCos(-11.54, 4.22);
            Assert.AreEqual(cos.Solve(), -1.72, 0.009);
        }

        /// <summary>
        /// Sum for cos and log test14.
        /// </summary>
        [TestMethod()]
        public void SumForCosAndLogTest14()
        {
            Function integral = new Function(1, 3);
            Assert.AreEqual(integral.SumForCosAndLog(0.45, 10.23), 5.084, 0.0009);
        }

        /// <summary>
        /// Sum for cos and quad test15.
        /// </summary>
        [TestMethod()]
        public void SumForCosAndQuadTest15()
        {
            Function integral = new Function(-8, -6);
            Assert.AreEqual(integral.SumForCosAndQuad(-8, -6), 99.96, 0.003);
        }
    }
}