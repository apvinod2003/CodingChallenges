using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions.DynamicProgramming;
using LeetCodeSolutions.TreesAndGraphs;

namespace LeetCodeSolutions.Design.Tests
{
    [TestClass()]
    public class SerDeSerBSTTests
    {
        SerDeSerBST obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new SerDeSerBST();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void serializeTest()
        {
            TreeNode root = new TreeNode(5, new TreeNode(1), new TreeNode(8, new TreeNode(7), new TreeNode(9)));
            string str = obj.serialize(root);
            Assert.IsTrue(str == "5,1,N,N,8,7,N,N,9,N,N");
        }

        [TestMethod()]
        public void DeserializeTest()
        {
            
            string str = "5,1,N,N,8,7,N,N,9,N,N";

            TreeNode root = obj.deserialize(str);

            Assert.IsTrue(root.val == 5 && root.left.val == 1 && root.right.val == 8 && root.right.left.val == 7 && root.right.right.val == 9);
        }

        [TestMethod()]
        public void DeserializeTest1()
        {

            string str = "41,37,44,24,39,42,48,1,35,38,40,N,43,46,49,0,2,30,36,N,N,N,N,N,N,45,47,N,N,N,N,N,4,29,32,N,N,N,N,N,N,3,9,26,N,31,34,N,N,7,11,25,27,N,N,33,N,6,8,10,16,N,N,N,28,N,N,5,N,N,N,N,N,15,19,N,N,N,N,12,N,18,20,N,13,17,N,N,22,N,14,N,N,21,23,";

            TreeNode root = obj.deserialize(str);

            Assert.IsTrue(root.val == 41 );
        }
    }
}