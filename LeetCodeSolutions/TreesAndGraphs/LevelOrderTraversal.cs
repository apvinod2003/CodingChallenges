namespace LeetCodeSolutions.TreesAndGraphs
{
    public class LevelOrderTraversal
    {
        private static IList<IList<int>> list;
        
        /// <summary>
        /// Approach is recursive. Add current node to list with level 0, and left, right to list with level 1 and so on untill the entire tree is traversed.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null) return null;

            list = new List<IList<int>>();

            AddOneLevel(root, 0);

            return list;
        }

        private static void AddOneLevel(TreeNode node, int level)
        {
            if(node == null) return;

            if (list.Count == level)
                list.Add(new List<int>());

            list[level].Add(node.val);

            AddOneLevel(node.left, level + 1);
            AddOneLevel(node.right, level + 1);

        }
    }
}
