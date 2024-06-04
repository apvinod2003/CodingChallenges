using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hackerrank.ProblemSolving.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.ProblemSolving.Algorithms.Tests
{
    [TestClass()]
    public class ApplesAndOrangesTests
    {
        ApplesAndOranges obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new ApplesAndOranges();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void countApplesAndOrangesTest()
        {
            //ApplesAndOranges.countApplesAndOranges()
            Assert.IsTrue(true);
        }
    }
}