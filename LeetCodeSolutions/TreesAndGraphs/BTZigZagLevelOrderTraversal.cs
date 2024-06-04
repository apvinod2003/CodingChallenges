namespace LeetCodeSolutions.TreesAndGraphs
{

    public class BTZigZagLevelOrderTraversal
    {
        private static IList<IList<int>> list;
        public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            
            list = new List<IList<int>>();

            if(root == null) return list; // return empty list if root is null (as per leetcode requirements)
            
            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(root);
            while (q.Count > 0)
            {
                List<int> l = new List<int>();
                int qCount = q.Count;
                for (int i = 0; i < qCount; i++)
                {
                    TreeNode node = q.Dequeue();
                    l.Add(node.val);

                    if(node.left != null)
                        q.Enqueue(node.left);
                    if(node.right != null)
                        q.Enqueue(node.right);

                    
                }

                if (list.Count % 2 != 0) // odd number levels should be left to right, otherwise right to left.
                {
                    l.Reverse();
                }

                list.Add(l);

            }

            return list;
        }

        
    }
}
