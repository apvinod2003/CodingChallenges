using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.TreesAndGraphs.Tests
{
    [TestClass()]
    public class ValidateBinarySearchTreeTests
    {
        [TestMethod()]
        public void IsValidBSTTest()
        {
            TreeNode root = new TreeNode(5, new TreeNode(1), new TreeNode(4, new TreeNode(3), new TreeNode(6)));

            Assert.IsFalse(ValidateBinarySearchTree.IsValidBST(root));
        }

        [TestMethod()]
        public void IsValidBSTTest1()
        {
            TreeNode root = new TreeNode(2, new TreeNode(1), new TreeNode(3));

            Assert.IsTrue(ValidateBinarySearchTree.IsValidBST(root));
        }
    }
}