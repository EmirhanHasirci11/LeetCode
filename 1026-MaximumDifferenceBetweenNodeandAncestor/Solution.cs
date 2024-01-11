namespace MaximumDifferenceBetweenNodeandAncestor
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

    public class Solution
    {
        public int diffVal = 0;        
        public int MaxAncestorDiff(TreeNode root)
        {
            if (root == null)
                return 0;
            int min = root.val, max = root.val;
            diff(root, min, max);
            return diffVal;
        }
        public void diff(TreeNode root, int min, int max)
        {
            if (root == null)
                return;
            diffVal = Math.Max(diffVal, Math.Max(Math.Abs(min - root.val), Math.Abs(max - root.val)));
            min = Math.Min(min, root.val);
            max = Math.Max(max, root.val);
            diff(root.left, min, max);
            diff(root.right, min, max);
        }
    }
}