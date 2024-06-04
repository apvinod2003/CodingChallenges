using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.TreesAndGraphs.Tests
{
    [TestClass()]
    public class NumberOfIslandsTests
    {
        [TestMethod()]
        public void NumIslandsTest()
        {
            char[][] grid = [['1', '1', '1', '1', '0'], ['1', '1', '0', '1', '0'], ['1', '1', '0', '0', '0'], ['0', '0', '0', '0', '0']];

            Assert.IsTrue(NumberOfIslands.NumIslands(grid) == 1);
        }

        [TestMethod()]
        public void NumIslandsTest1()
        {
            char[][] grid = [['1', '1', '0', '0', '0'], ['1', '1', '0', '0', '0'], ['0', '0', '1', '0', '0'], ['0', '0', '0', '1', '1']];

            Assert.IsTrue(NumberOfIslands.NumIslands(grid) == 3);
        }
    }
}