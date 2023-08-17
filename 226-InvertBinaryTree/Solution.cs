namespace InvertBinaryTree
{
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;
            InvertTree(root.left);
            InvertTree(root.right);
            (root.left, root.right) = (root.right, root.left);
            return root;
        }
    }
}