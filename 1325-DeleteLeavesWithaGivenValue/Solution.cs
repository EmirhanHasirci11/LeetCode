namespace DeleteLeavesWithaGivenValue
{
    internal class Solution
    {        
        public TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            if (root.left != null) root.left = RemoveLeafNodes(root.left, target);
            if (root.right != null) root.right = RemoveLeafNodes(root.right, target);
            return root.left == root.right && root.val == target ? null : root;
        }
    }
}
