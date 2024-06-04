using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Others.Tests
{
    [TestClass()]
    public class RomanToIntegerTests
    {

        RomanToInteger obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new RomanToInteger();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }
        [TestMethod()]
        public void RomanToIntTest()
        {
            Assert.IsTrue(obj.RomanToInt("III") == 3);
        }

        [TestMethod()]
        public void RomanToIntTest1()
        {
            Assert.IsTrue(obj.RomanToInt("LVIII") == 58);
        }
    }
}