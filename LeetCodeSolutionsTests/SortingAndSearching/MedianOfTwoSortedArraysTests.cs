using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.SortingAndSearching.Tests
{
    [TestClass()]
    public class MedianOfTwoSortedArraysTests
    {
        MedianOfTwoSortedArrays obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new MedianOfTwoSortedArrays();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void FindMedianSortedArraysTest()
        {
            int[] num1 = { 1,3,8,9,15 };
            int[] num2 = { 7, 11, 18, 19, 21, 25 };
            Assert.IsTrue(obj.FindMedianSortedArrays(num1, num2) == 11);
        }

        [TestMethod()]
        public void FindMedianSortedArraysTest1()
        {
            int[] num1 = { 1, 2 };
            int[] num2 = { 3, 4 };
            Assert.IsTrue(obj.FindMedianSortedArrays(num1, num2) == 2.5);
        }
    }
}