namespace SumofLeftLeaves
{
    internal class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            public int SumOfLeftLeaves(TreeNode root)
            {
                if (root == null) return 0;
                int ans = 0;
                if (root.left != null)
                {
                    if (root.left.left == null && root.left.right == null) ans += root.left.val;
                    else ans += SumOfLeftLeaves(root.left);
                }
                ans += SumOfLeftLeaves(root.right);

                return ans;
            }
        }
    }
}
