using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Array.Tests
{
    [TestClass()]
    public class OneDimensionalArrayTests
    {
        [TestMethod()]
        public void NegativElements()
        {
            OneDimensionalArray Array = new OneDimensionalArray("A");
            Assert.AreEqual(Array.NegativElements(), 3);
        }

        [TestMethod()]
        public void NegativElements1()
        {
            OneDimensionalArray Array = new OneDimensionalArray("A");
            Assert.AreEqual(Array.NegativElements(2), 1);
        }

        [TestMethod()]
        public void ArrayABTest()
        {
            OneDimensionalArray ArrayA = new OneDimensionalArray("A");
            OneDimensionalArray ArrayB = new OneDimensionalArray("B");
            OneDimensionalArray ArrayC = new OneDimensionalArray("C");
            OneDimensionalArray MultiplicatoinAandC = new OneDimensionalArray("A*C");
            OneDimensionalArray MultiplicatoinAandB = new OneDimensionalArray("A*B");
            MultiplicatoinAandC = ArrayA * ArrayC;
            MultiplicatoinAandB = ArrayA * ArrayB;
            Assert.AreNotEqual(MultiplicatoinAandC, ArrayA);
            Assert.AreNotEqual(MultiplicatoinAandB, ArrayA);
        }
    }
}