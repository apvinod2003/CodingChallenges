using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.TreesAndGraphs.Tests
{
    [TestClass()]
    public class LowestCommonAncestorBTTests
    {
        [TestMethod()]
        public void LowestCommonAncestorTest()
        {
            TreeNode p = new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4)));
            TreeNode q = new TreeNode(1, new TreeNode(0), new TreeNode(8));
            TreeNode root = new TreeNode(3, p , q);

            Assert.IsTrue(LowestCommonAncestorBT.LowestCommonAncestor(root, p, q) == root);
        }
    }
}