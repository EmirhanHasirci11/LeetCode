namespace DiameterofBinaryTree
{
    public class Solution
    {
        int max = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            this.Helper(root);
            return max;
        }

        public int Helper(TreeNode root)
        {
            if (root == null) return 0;
            int left = this.Helper(root.left);
            int right = this.Helper(root.right);
            max = Math.Max(max, left + right);
            return Math.Max(left, right) + 1;
        }
    }
}