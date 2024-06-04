using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.DynamicProgramming.Tests
{


    [TestClass()]
    public class BuySellStocksTests
    {
        BuySellStocks obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new BuySellStocks();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void MaxProfitTest()
        {
            int[] prices = [7, 1, 5, 3, 6, 4];

            Assert.IsTrue(obj.MaxProfit(prices) == 5);
        }

        [TestMethod()]
        public void MaxProfitTest1()
        {
            int[] prices = [1,4,2];

            Assert.IsTrue(obj.MaxProfit(prices) == 3);
        }

        [TestMethod()]
        public void MaxProfitTest2()
        {
            int[] prices = [2,1];

            Assert.IsTrue(obj.MaxProfit(prices) == 0);
        }

        [TestMethod()]
        public void MaxProfitTest3()
        {
            int[] prices = [2, 1, 2, 1, 0, 0, 1];

            Assert.IsTrue(obj.MaxProfit(prices) == 1);
        }
    }
}