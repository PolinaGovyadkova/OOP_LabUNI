using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Wpf.Tests
{
    /// <summary>
    /// MainWindowTests
    /// </summary>
    [TestClass()]
    public class MainWindowTests
    {
        /// <summary>
        /// Update for students test.
        /// </summary>
        [TestMethod()]
        public void UpdateForStudentsTest()
        {
            //new_fileTest - файл, который должен получиться;
            FileStream file = new FileStream("H:\\new_file.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            FileStream file1 = new FileStream("H:\\new_fileTest.txt", FileMode.Open);
            StreamReader reader1 = new StreamReader(file1);
            Assert.AreEqual(reader.ReadToEnd(), reader1.ReadToEnd());
        }

        /// <summary>
        /// Update for pupils test.
        /// </summary>
        [TestMethod()]
        public void UpdateForPupilsTest()
        {
            //new_fileTest1 - файл, который должен получиться;
            FileStream file = new FileStream("H:\\new_file1.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            FileStream file1 = new FileStream("H:\\new_fileTest1.txt", FileMode.Open);
            StreamReader reader1 = new StreamReader(file1);
            Assert.AreEqual(reader.ReadToEnd(), reader1.ReadToEnd());
        }

        /// <summary>
        /// Updates the brush test.
        /// </summary>
        [TestMethod()]
        public void UpdateBrushTest()
        {
            //new_fileTest2 - файл, который должен получиться;
            FileStream file = new FileStream("H:\\new_file2.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            FileStream file1 = new FileStream("H:\\new_fileTest2.txt", FileMode.Open);
            StreamReader reader1 = new StreamReader(file1);
            Assert.AreEqual(reader.ReadToEnd(), reader1.ReadToEnd());
        }

        /// <summary>
        /// Update the error test.
        /// </summary>
        [TestMethod()]
        public void UpdateErrorTest()
        {
            //error_file - файл c ошибкой
            FileStream file = new FileStream("H:\\new_file2.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            FileStream file1 = new FileStream("H:\\error_file.txt", FileMode.Open);
            StreamReader reader1 = new StreamReader(file1);
            Assert.AreNotEqual(reader.ReadToEnd(), reader1.ReadToEnd());
        }
    }
}