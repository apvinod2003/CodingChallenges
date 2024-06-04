using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.SortingAndSearching.Tests
{
    [TestClass()]
    public class SearchInRotatedSortedArrayTests
    {
        SearchInRotatedSortedArray obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new SearchInRotatedSortedArray();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void SearchTest()
        {
            int[] nums = [4, 5, 6, 7, 0, 1, 2];

            Assert.IsTrue(obj.Search(nums, 0) == 4);
        }

        [TestMethod()]
        public void SearchTest1()
        {
            int[] nums = [4, 5, 6, 7, 0, 1, 2];

            Assert.IsTrue(obj.Search(nums, 3) == -1);
        }
    }
}