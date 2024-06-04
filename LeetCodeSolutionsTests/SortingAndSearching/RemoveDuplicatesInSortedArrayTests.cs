using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.SortingAndSearching.Tests
{


    [TestClass()]
    public class RemoveDuplicatesInSortedArrayTests
    {
        private RemoveDuplicatesInSortedArray remDups;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            remDups = new RemoveDuplicatesInSortedArray();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            remDups = null;
        }
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            int[] arr = [1, 1, 2];
            int res = remDups.RemoveDuplicates(arr);

            Assert.IsTrue(res == 2);

        }

        [TestMethod()]
        public void RemoveDuplicatesTest1()
        {
            int[] arr = [1, 1];
            int res = remDups.RemoveDuplicates(arr);

            Assert.IsTrue(res == 1);

        }
    }
}