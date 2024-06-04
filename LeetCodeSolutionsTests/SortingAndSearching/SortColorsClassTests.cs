using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.SortingAndSearching.Tests
{
    [TestClass()]
    public class SortColorsClassTests
    {
        SortColorsClass obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new SortColorsClass();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }
        [TestMethod()]
        public void SortColorsTest()
        {
            int[] nums = [2, 0, 2, 1, 1, 0];

            obj.SortColors(nums);

            Assert.IsTrue(nums[0] == 0 && nums[1] == 0 && nums[2] == 1 && nums[3] == 1 && nums[4] == 2 && nums[5] == 2);
        }
    }
}