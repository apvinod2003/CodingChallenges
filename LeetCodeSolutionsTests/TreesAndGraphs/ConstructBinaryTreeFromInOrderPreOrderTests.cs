using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.TreesAndGraphs.Tests
{
    [TestClass()]
    public class ConstructBinaryTreeFromInOrderPreOrderTests
    {
        [TestMethod()]
        public void BuildTreeTest()
        {
            int[] preorder = [3, 9, 20, 15, 7];
            int[] inorder = [9, 3, 15, 20, 7];

            TreeNode root = ConstructBinaryTreeFromInOrderPreOrder.BuildTree(preorder, inorder);

            Assert.IsTrue(root.val == 3 && root.left.val == 9 && root.right.val == 20 && root.right.left.val == 15 && root.right.right.val == 7);
        }
    }
}