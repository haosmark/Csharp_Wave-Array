using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Wave_Array;

namespace WaveArray.Tests
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void Test_1()
        {
            // Arrange
            List<int> data = new List<int> { 1 };
            List<int> expected = new List<int> { 1 };

            // Act
            List<int> actual = Solution.WaveArray(data);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_1_2_3()
        {
            // Arrange
            List<int> data = new List<int> { 1, 2, 3 };
            List<int> expected = new List<int> { 2, 1, 3 };

            // Act
            List<int> actual = Solution.WaveArray(data);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_6_2_3_4()
        {
            // Arrange
            List<int> data = new List<int> { 6, 2, 3, 4 };
            List<int> expected = new List<int> { 3, 2, 6, 4 };

            // Act
            List<int> actual = Solution.WaveArray(data);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_null()
        {
            // Arrange
            List<int> data = null;
            List<int> expected = new List<int> { 3, 2, 6, 4 };

            // Act
            List<int> actual = Solution.WaveArray(data);

            // Assert            
        }
    }
}
