namespace LeetCodeSolutions.TreesAndGraphs
{
    public class LowestCommonAncestorBT
    {
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;

            if (root == p || root == q) return root;

            TreeNode left = LowestCommonAncestor(root.left, p, q);
            TreeNode right = LowestCommonAncestor(root.right, p, q);

            if(left != null && right != null) return root;

            if (left == null && right == null) return null;

            return left != null ? left : right;
        }
    }
}
