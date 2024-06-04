using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class SpiralMatrixTests
    {
        [TestMethod()]
        public void SpiralOrderTest()
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] { 1,2,3,4 };
            matrix[1] = new int[4] { 5,6,7,8 };
            matrix[2] = new int[4] { 9,10,11,12 };

            var result =  SpiralMatrix.SpiralOrder(matrix);

            Assert.IsTrue(result[0] == 1);
            Assert.IsTrue(result[1] == 2);

            Assert.IsTrue(result[2] == 3);
            Assert.IsTrue(result[3] == 4);
            Assert.IsTrue(result[4] == 8);
            Assert.IsTrue(result[5] == 12);
            Assert.IsTrue(result[6] == 11);
            Assert.IsTrue(result[7] == 10);
            Assert.IsTrue(result[8] == 9);
            Assert.IsTrue(result[9] == 5);
            Assert.IsTrue(result[10] == 6);
            Assert.IsTrue(result[11] == 7);
        }
    }
}