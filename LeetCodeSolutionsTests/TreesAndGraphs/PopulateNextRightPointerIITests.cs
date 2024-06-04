using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.TreesAndGraphs.Tests
{
    [TestClass()]
    public class PopulateNextRightPointerIITests
    {
        [TestMethod()]
        public void ConnectTest()
        {
            Node root = new Node(1, new Node(2, new Node(4), new Node(5), null), new Node(3, null, new Node(7), null), null);
            root = PopulateNextRightPointerII.Connect(root);

            Assert.IsTrue(root.next == null && root.left.next == root.right && root.left.left.next == root.left.right
                && root.left.right.next == root.right.right);
        }


        [TestMethod()]
        public void ConnectTest1()
        {
            Node root = new Node(2, new Node(1, new Node(0, new Node(2), null, null), new Node(7, new Node(1), new Node(0), null), null), new Node(3, new Node(9), new Node(1, new Node(8), new Node(8), null), null), null);
            root = PopulateNextRightPointerII.Connect(root);

            Assert.IsTrue(true);
            
        }
    }
}