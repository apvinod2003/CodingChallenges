using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class SetMatrixZerosTests
    {
        [TestMethod()]
        public void SetZeroesTest()
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[3] { 1, 1, 1 };
            matrix[1] = new int[3] { 1, 0, 1 };
            matrix[2] = new int[3] { 1, 1, 1 };
            SetMatrixZeros.SetZeroes(matrix);

            //excpected output: Output: [[1,0,1],[0,0,0],[1,0,1]]

            Assert.IsTrue(matrix[0][0] == 1 && matrix[0][1] == 0 && matrix[0][2] == 1 
                       && matrix[1][0] == 0 && matrix[1][1] == 0 && matrix[1][2] == 0
                       && matrix[2][0] == 1 && matrix[2][1] == 0 && matrix[2][2] == 1);
        }

        [TestMethod()]
        public void SetZeroesTest1()
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] { 0, 1, 2, 0 };
            matrix[1] = new int[4] { 3,4,5,2 };
            matrix[2] = new int[4] { 1,3,1,5 };
            SetMatrixZeros.SetZeroes(matrix);

            //excpected output: Output: [[1,0,1],[0,0,0],[1,0,1]]

            Assert.IsTrue(matrix[0][0] == 0 && matrix[0][1] == 0 && matrix[0][2] == 0 && matrix[0][3] == 0
                       && matrix[1][0] == 0 && matrix[1][1] == 4 && matrix[1][2] == 5 && matrix[1][3] == 0
                       && matrix[2][0] == 0 && matrix[2][1] == 3 && matrix[2][2] == 1 && matrix[2][3] == 0);
        }
    }
}