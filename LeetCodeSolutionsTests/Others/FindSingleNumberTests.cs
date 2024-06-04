using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions.Design;
using NuGet.Frameworks;

namespace LeetCodeSolutions.Others.Tests
{
    [TestClass()]
    public class FindSingleNumberTests
    {
        FindSingleNumber obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new FindSingleNumber();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void SingleNumber1Test()
        {
            int[] nums = [1, 2, 1, 3, 3];
            Assert.IsTrue(obj.SingleNumber1(nums) == 2);
        }
    }
}