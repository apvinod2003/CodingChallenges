using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.TreesAndGraphs.Tests
{
    [TestClass()]
    public class LowestCommonAncestorTests
    {
        [TestMethod()]
        public void LowestCommonAncestorTest()
        {
            TreeNode root = new TreeNode(6, new TreeNode(2 , new TreeNode(0), new TreeNode(4, new TreeNode(3), new TreeNode(5))), new TreeNode(8, new TreeNode(7), new TreeNode(9)));

            TreeNode p = new TreeNode(7);
            TreeNode q = new TreeNode(6);

            var node = LowestCommonAncestorBST.LowestCommonAncestor(root,p, q);

            Assert.IsTrue(node != null && node.val == 6);
        }
    }
}