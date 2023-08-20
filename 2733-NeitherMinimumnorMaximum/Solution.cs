namespace NeitherMinimumnorMaximum
{
    internal class Solution
    {        
        public int FindNonMinOrMax(int[] nums)
        {
            if (nums.Length <= 2)
                return -1;
            
            Array.Sort<int>(nums);
            return nums[1];
        }
    }
}