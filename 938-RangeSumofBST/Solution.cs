namespace RangeSumofBST
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
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null) return 0;
            int sumOfCurrent = (root.val >= low && root.val <= high ? root.val : 0);
            int leftSum = RangeSumBST(root.left, low, high);
            int rightSum = RangeSumBST(root.right, low, high);
            return sumOfCurrent + leftSum + rightSum;
        }
    }
}