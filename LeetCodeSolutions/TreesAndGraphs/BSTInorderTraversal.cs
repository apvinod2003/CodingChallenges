namespace LeetCodeSolutions.TreesAndGraphs
{
    public class BSTInorderTraversal
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = root;

            while (curr != null || stack.Count > 0)
            {
                if(curr == null && stack.Count > 0) // you are at leaf's left (null), pop parent node, add to list and traverse right.
                {
                    curr = stack.Pop();
                    result.Add(curr.val);
                    curr = curr.right;
                }
                if(curr != null) // if curr is not null, always push to stack and attempt a left traversal.
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
            }

            return result;
        }
    }
}
