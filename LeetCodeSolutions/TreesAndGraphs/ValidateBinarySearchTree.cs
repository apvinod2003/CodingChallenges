namespace LeetCodeSolutions.TreesAndGraphs
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class ValidateBinarySearchTree
    {
        /// <summary>
        /// Approach: Check if each node's left is lesser than root and right is greater than root , if not return false.
        /// Then recursively repeat the operation for left and right subtree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsValidBST(TreeNode root)
        {
            return IsValid(root, null, null);
        }

        private static bool IsValid(TreeNode node, int? min, int? max) 
        {
            if(node == null) { return true; }

            if (min.HasValue && node.val <= min) { return false; }

            if (max.HasValue && node.val >= max) { return false; }

            return IsValid(node.left, min, node.val) && IsValid(node.right, node.val, max);
        }
    }
}
