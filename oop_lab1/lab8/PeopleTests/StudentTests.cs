using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace People.Tests
{
    /// <summary>
    /// StudentTests
    /// </summary>
    [TestClass()]
    public class StudentTests
    {
        /// <summary>
        /// Informations the test.
        /// </summary>
        [TestMethod()]
        public void InfoTest()
        {
            double sum = 0;
            int count = 0;
            double[] Array = new double[12];
            Random random = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(20);
                sum += Array[i];
                count++;
            }
            Pupil pupil = new Pupil("", 2005, "", "", "", Array);
            Assert.AreEqual(pupil.Info(), Math.Round(sum / count, 2));
        }

        /// <summary>
        /// Informations the test1.
        /// </summary>
        [TestMethod()]
        public void InfoTest1()
        {
            double[] Array = new double[12];
            Random random = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(20);
            }
            Working working = new Working("", 2005, "", "", Array);
            Assert.AreEqual(working.Info(), Array.Max());
        }

        /// <summary>
        /// Adds the chars throws exception.
        /// </summary>
        [TestMethod]
        public void AddCharsThrowsException()
        {
            double[] Array = new double[12];
            Exception expectedExcetpion = null;
            try
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = Convert.ToDouble("h");
                }
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }
            Working working = new Working("", 2005, "", "", Array);
            Assert.IsNotNull(expectedExcetpion);
        }
    }
}