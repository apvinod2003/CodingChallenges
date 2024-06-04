using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.TreesAndGraphs.Tests
{
    [TestClass()]
    public class BSTInorderTraversalTests
    {
        [TestMethod()]
        public void InorderTraversalTest()
        {
            TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3), null));
            var list = BSTInorderTraversal.InorderTraversal(root);
            Assert.IsTrue(list[0] == 1 && list[1] == 3 && list[2] == 2);
        }
    }
}