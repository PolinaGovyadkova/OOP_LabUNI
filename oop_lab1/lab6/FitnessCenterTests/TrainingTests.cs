using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace FitnessCenter.Tests
{
    /// <summary>
    /// TrainingTests
    /// </summary>
    [TestClass()]
    public class TrainingTests
    {
        /// <summary>
        /// Alls exercise test.
        /// </summary>
        [TestMethod()]
        public void AllExerciseTest()
        {
            FileStream file = new FileStream("H:\\ AllExercise.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            Assert.AreEqual(reader.ReadToEnd(), "3");
            reader.Close();
        }

        /// <summary>
        /// Populars type of exercise test.
        /// </summary>
        [TestMethod()]
        public void PopularTypeOfExerciseTest()
        {
            FileStream file = new FileStream("H:\\PopularTypeOfExercise.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            Assert.AreEqual(reader.ReadToEnd(), "Fitness_yoga");
            reader.Close();
        }

        /// <summary>
        /// Totals exercise test.
        /// </summary>
        [TestMethod()]
        public void TotalExerciseTest()
        {
            FileStream file = new FileStream("H:\\TotalExercise.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            Assert.AreEqual(reader.ReadToEnd(), "2");
            reader.Close();
        }
    }
}