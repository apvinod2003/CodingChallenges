using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.SortingAndSearching.Tests
{
    [TestClass()]
    public class Search2DMatrixTests
    {
        Search2DMatrix obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new Search2DMatrix();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }
        [TestMethod()]
        public void SearchMatrixTest()
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] { 1, 3, 5, 7 };
            matrix[1] = new int[4] { 10, 11, 16, 20 };
            matrix[2] = new int[4] { 23, 30, 34, 60 };

            Assert.IsTrue(obj.SearchMatrix(matrix, 34) == true);
        }

        [TestMethod()]
        public void SearchMatrixTest1()
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] { 1, 3, 5, 7 };
            matrix[1] = new int[4] { 10, 11, 16, 20 };
            matrix[2] = new int[4] { 23, 30, 34, 60 };

            Assert.IsTrue(obj.SearchMatrix(matrix, 35) == false);
        }

        [TestMethod()]
        public void SearchMatrixTest3()
        {
            int[][] matrix = new int[1][];
            matrix[0] = new int[1] { 1 };
            

            Assert.IsTrue(obj.SearchMatrix(matrix, 2) == false);
        }
    }
}