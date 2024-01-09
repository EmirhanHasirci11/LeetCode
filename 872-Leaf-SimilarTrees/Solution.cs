namespace Leaf_SimilarTrees
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

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            SearchLeaf(root1, list1);
            SearchLeaf(root2, list2);
            return list1.SequenceEqual(list2);
            
           
        }
        public void SearchLeaf(TreeNode root,List<int> list)
        {
            if(root == null) return;
            if(root.left == null && root.right==null) list.Add(root.val);
            SearchLeaf(root.left,list);
            SearchLeaf(root.right,list);
            
        }
    }
}