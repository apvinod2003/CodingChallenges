using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.SortingAndSearching.Tests
{
    [TestClass()]
    public class MergeSortedArrayTests
    {
        private MergeSortedArray obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new MergeSortedArray();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void MergeTest()
        {
            int[] a = [1, 2, 3, 0, 0, 0];
            int[] b = [2, 5, 6];

            obj.Merge(a, 3, b, 3);
        }
    }
}