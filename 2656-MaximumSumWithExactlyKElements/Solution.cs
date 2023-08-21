namespace MaximumSumWithExactlyKElements
{
    internal class Solution
    {
        public int MaximizeSum(int[] nums, int k)
        {
            int max = nums.Max();
            int count = max;
            for(int i=1;i<k;i++)
            {
                max += 1;
                count += max;

            }
            return count;
        }
    }
}