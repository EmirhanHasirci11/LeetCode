namespace SumRoottoLeafNumbers
{
    internal class Solution
    {
        public int SumNumbers(TreeNode root)
        {
            return Sum(root, 0);
        }
        public int Sum(TreeNode n, int s)
        {
            if (n == null) return 0;
            if (n.right == null && n.left == null) return s * 10 + n.val;
            return Sum(n.left, s * 10 + n.val) + Sum(n.right, s * 10 + n.val);
        }
    }
}
