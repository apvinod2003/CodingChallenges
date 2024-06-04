namespace LeetCodeSolutions.TreesAndGraphs
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    public class PopulateNextRightPointers
    {
        public static Node Connect(Node root)
        {
            Connect(null, root, true);
            return root;
        }

        private static void Connect(Node parent, Node curr, bool isRight)
        {
            if (curr == null) return; //we've gone past leaf node, return.

            if(isRight)
            {
                //For right node, assign to parent's next left.
                curr.next = parent?.next?.left;
            }
            else 
            {
                //This is left node, so assign next to parent's right.
                curr.next = parent.right;
            }

            Connect(curr, curr.left, false);
            Connect(curr, curr.right, true);
        }

    }
}
