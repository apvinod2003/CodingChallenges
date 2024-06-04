using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.SortingAndSearching.Tests
{
    [TestClass()]
    public class Search2DMatrixIITests
    {
        Search2DMatrixII obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new Search2DMatrixII();
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
            int[][] matrix = new int[][]
            {
                new int[] { 1, 4, 7, 11, 15 },
                new int[] { 2, 5, 8, 12, 19 },
                new int[] { 3, 6, 9, 16, 22 },
                new int[] { 10, 13, 14, 17, 24 },
                new int[] { 18, 21, 23, 26, 30 }
            };

            Assert.IsTrue(obj.SearchMatrix(matrix, 5));

        }

        [TestMethod()]
        public void SearchMatrixTest1()
        {
            int[][] matrix = new int[][]
            {
                new int[] { 1, 4, 7, 11, 15 },
                new int[] { 2, 5, 8, 12, 19 },
                new int[] { 3, 6, 9, 16, 22 },
                new int[] { 10, 13, 14, 17, 24 },
                new int[] { 18, 21, 23, 26, 30 }
            };

            Assert.IsFalse(obj.SearchMatrix(matrix, 99));

        }

        [TestMethod()]
        public void SearchMatrixTest2()
        {
            int[][] matrix = new int[][]
            {
                new int[] { -5 }
            };

            Assert.IsFalse(obj.SearchMatrix(matrix, -10));

        }
    }
}