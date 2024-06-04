using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.TreesAndGraphs.Tests
{
    [TestClass()]
    public class PopulateNextRightPointersTests
    {
        [TestMethod()]
        public void ConnectTest()
        {
            Node root = new Node(1, new Node(2, new Node(4), new Node(5), null), new Node(3, new Node(6), new Node(7), null), null);
            root = PopulateNextRightPointers.Connect(root);

            Assert.IsTrue(root.next == null && root.left.next == root.right && root.left.left.next == root.left.right 
                && root.left.right.next == root.right.left && root.right.left.next == root.right.right);
        }
    }
}