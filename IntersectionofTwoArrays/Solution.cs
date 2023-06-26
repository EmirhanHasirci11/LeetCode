namespace IntersectionofTwoArrays
{
    internal class Solution
    {      
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> first = new(nums1);
            HashSet<int> second = new(nums2);
            foreach (int n in first)
                if (!second.Contains(n))
                    first.Remove(n);
            return first.ToArray();
        }
    }
}