using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.TreesAndGraphs.Graphs.Tests
{
    [TestClass()]
    public class CloneGraphClassTests
    {
        [TestMethod()]
        public void CloneGraphTest()
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);

            one.neighbors.Add(two); one.neighbors.Add(four);
            two.neighbors.Add(one); two.neighbors.Add(three);
            three.neighbors.Add(two);three.neighbors.Add(four);
            four.neighbors.Add(one); four.neighbors.Add(three);

            Node newOne = CloneGraphClass.CloneGraph(one);

            Assert.IsTrue(newOne.val == 1 && newOne.neighbors.Count == 2 && newOne.neighbors[0].val == 2 && newOne.neighbors[1].val == 4);

            Node newTwo = newOne.neighbors[0];
            Assert.IsTrue(newTwo.val == 2 && newTwo.neighbors.Count == 2 && newTwo.neighbors[0].val == 1 && newTwo.neighbors[1].val == 3);

            Node newThree = newTwo.neighbors[1];
            Assert.IsTrue(newThree.val == 3 && newThree.neighbors.Count == 2 && newThree.neighbors[0].val == 2 && newThree.neighbors[1].val == 4);

            Node newFour = newThree.neighbors[1];

            Assert.IsTrue(newFour.val == 4 && newFour.neighbors.Count == 2 && newFour.neighbors[0].val == 1 && newFour.neighbors[1].val == 3);

        }
    }
}