namespace AmountofTimeforBinaryTreetoBeInfected
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
    internal class Solution
    {
        private int maxDistance = 0;
        public int AmountOfTime(TreeNode root, int start)
        {
            traverse(root, start);
            return maxDistance;

        }
        private int traverse(TreeNode root, int start)
        {
            int depth = 0;
            if (root == null)
            {
                return depth;
            }

            int leftDepth = traverse(root.left, start);
            int rightDepth = traverse(root.right, start);

            if (root.val == start)
            {
                maxDistance = Math.Max(leftDepth, rightDepth);
                depth = -1;
            }
            else if (leftDepth >= 0 && rightDepth >= 0)
            {
                depth = Math.Max(leftDepth, rightDepth) + 1;
            }
            else
            {
                int distance = Math.Abs(leftDepth) + Math.Abs(rightDepth);
                maxDistance = Math.Max(maxDistance, distance);
                depth = Math.Min(leftDepth, rightDepth) - 1;
            }

            return depth;
        }

    }
}