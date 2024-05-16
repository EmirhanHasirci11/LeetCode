namespace EvaluateBooleanBinaryTree
{
    internal class Solution
    {        
        public bool EvaluateTree(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }
            if (root.val == 0)
            {
                return false;
            }
            if (root.val == 1)
            {
                return true;
            }
            bool left = EvaluateTree(root.left);
            bool right = EvaluateTree(root.right);
            return root.val == 2 ? left | right : left & right;
        }
    }
}   
