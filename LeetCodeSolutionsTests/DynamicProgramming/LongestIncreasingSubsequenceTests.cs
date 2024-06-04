using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.DynamicProgramming.Tests
{
    [TestClass()]
    public class LongestIncreasingSubsequenceTests
    {
        LongestIncreasingSubsequence obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new LongestIncreasingSubsequence();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void LengthOfLISTest()
        {
            int[] nums = [10, 9, 2, 5, 3, 7, 101, 18];

            Assert.IsTrue(obj.LengthOfLIS(nums) == 4);
        }
    }
}