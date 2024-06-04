using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class TwoSumTests
    {
        private TwoSumClass solution;
        public TwoSumTests()
        {
            solution = new TwoSumClass();
        }
        [TestMethod()]
        public void AssertTrueWhenNumbersAddupToTarget()
        {
            var result = solution.TwoSum([2, 7, 11, 15], 9);
            Assert.IsTrue(result.Length == 2 && result.Contains(0) && result.Contains(1));
        }

        [TestMethod()]
        public void AssertFalseWhenNumbersDontAddupToTarget()
        {
            var result = solution.TwoSum([2, 8, 11, 15], 9);
            Assert.IsFalse(result.Length == 2);
        }
    }
}