using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.TreesAndGraphs.Tests
{
    [TestClass()]
    public class BTZigZagLevelOrderTraversalTests
    {
        [TestMethod()]
        public void ZigzagLevelOrderTest()
        {
            TreeNode root = new TreeNode(3, new TreeNode(9, null, null), new TreeNode(20, new TreeNode(15, null, null), new TreeNode(7, null, null)));

            var result = BTZigZagLevelOrderTraversal.ZigzagLevelOrder(root);
        }

        [TestMethod()]
        public void ZigzagLevelOrderTest1()
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(4, null, null), null), new TreeNode(3, null, new TreeNode(5, null, null)));

            var result = BTZigZagLevelOrderTraversal.ZigzagLevelOrder(root);
        }
    }
}