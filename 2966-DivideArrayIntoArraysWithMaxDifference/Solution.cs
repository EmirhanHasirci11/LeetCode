namespace DivideArrayIntoArraysWithMaxDifference
{
    internal class Solution
    {       
        public int[][] DivideArray(int[] nums, int k)
        {
            Array.Sort(nums);
            List<int[]> res= new();
            for(int i=2;i<nums.Length;i+=3)
            {
                if (nums[i] - nums[i - 2] > k) return new int[0][];
                res.Add(new int[] { nums[i-2], nums[i - 1], nums[i] });
            }
            return res.ToArray();
        }
    }
}