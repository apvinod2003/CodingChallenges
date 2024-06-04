using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.TreesAndGraphs.Tests
{
    [TestClass()]
    public class LevelOrderTraversalTests
    {
        [TestMethod()]
        public void LevelOrderTest()
        {
            TreeNode root = new TreeNode(3, new TreeNode(9, null, null), new TreeNode(20, new TreeNode(15, null, null), new TreeNode(7, null, null)));

            var result = LevelOrderTraversal.LevelOrder(root);

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result[0][0] == 3 && result[1][0] == 9 && result[1][1] == 20 && result[2][0] == 15 && result[2][1] == 7);
        }
    }
}