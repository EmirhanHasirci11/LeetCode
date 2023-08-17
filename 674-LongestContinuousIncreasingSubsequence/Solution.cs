namespace LongestContinuousIncreasingSubsequence
{
    internal class Solution
    {               
        public int FindLengthOfLCIS(int[] nums)
        {
            int maxSubsequence = 1;
            int iterator = 1;
            int prevNum = nums[0];
            foreach (int num in nums)
            {
                if (prevNum < num)
                {
                    iterator++;

                    if (maxSubsequence < iterator)
                        maxSubsequence = iterator;
                }
                else
                    iterator = 1;
                prevNum= num;
            }
            return maxSubsequence;
        }
    }
}