using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class RotateImageTests
    {
        [TestMethod()]
        public void RotateTest()
        {
            int[][] matrix = new int[4][];
            matrix[0] = new int[4] { 5,1,9,11 };
            matrix[1] = new int[4] { 2,4,8,10 };
            matrix[2] = new int[4] { 13,3,6,7 };
            matrix[3] = new int[4] { 15,14,12,16 };
            RotateImage.Rotate(matrix);

            //excpected output: Output: [[1,0,1],[0,0,0],[1,0,1]]

            Assert.IsTrue(matrix[0][0] == 15 && matrix[0][1] == 13 && matrix[0][2] == 2 && matrix[0][3] == 5
                       && matrix[1][0] == 14 && matrix[1][1] == 3 && matrix[1][2] == 4 && matrix[1][3] == 1
                       && matrix[2][0] == 12 && matrix[2][1] == 6 && matrix[2][2] == 8 && matrix[2][3] == 9
                       && matrix[3][0] == 16 && matrix[3][1] == 7 && matrix[3][2] == 10 && matrix[3][3] == 11);                     
            
        }
    }
}