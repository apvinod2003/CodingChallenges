using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.SortingAndSearching.Tests
{
    [TestClass()]
    public class FindMinInRotatedSortedArrayTests
    {
        FindMinInRotatedSortedArray obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new FindMinInRotatedSortedArray();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void FindMinTest()
        {
            int[] nums = [4, 5, 6, 7, 0, 1, 2];

            Assert.IsTrue(obj.FindMin(nums) == 0);
        }
    }
}