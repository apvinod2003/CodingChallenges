using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.DynamicProgramming.Tests
{
    [TestClass()]
    public class MaxiSubArrayTests
    {
        MaxiSubArray obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new MaxiSubArray();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void MaxSubArrayTest()
        {
            int[] nums = [1];

            Assert.IsTrue(obj.MaxSubArray(nums) == 1);
        }
    }
}