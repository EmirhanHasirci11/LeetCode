namespace LongestIncreasingSubsequence
{
    internal class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            int[] dp = new int[nums.Length];
            Array.Fill(dp, 1);

            for (int i = 1; i < nums.Length; i++)
                for (int j = 0; j < nums.Length; j++)
                    if (nums[i] > nums[j])
                        dp[i] = Math.Max(dp[i], dp[j] + 1);

            return dp.Max();
        }
    }
}