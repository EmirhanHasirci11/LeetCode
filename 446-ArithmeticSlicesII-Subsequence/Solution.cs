namespace ArithmeticSlicesII_Subsequence
{
    internal class Solution
    {
        public int NumberOfArithmeticSlices(int[] nums)
        {
            int n = nums.Length;
            int total_count = 0;

            Dictionary<int, int>[] dp = new Dictionary<int, int>[n];

            for (int i = 0; i < n; ++i)
            {
                dp[i] = new Dictionary<int, int>();
            }

            for (int i = 1; i < n; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    long diff = (long)nums[i] - nums[j];
                    if (diff > int.MaxValue || diff < int.MinValue)
                    {
                        continue;
                    }

                    int diffInt = (int)diff;

                    dp[i][diffInt] = dp[i].GetValueOrDefault(diffInt) + 1;

                    if (dp[j].ContainsKey(diffInt))
                    {
                        dp[i][diffInt] += dp[j][diffInt];
                        total_count += dp[j][diffInt];
                    }
                }
            }

            return total_count;
        }
    }
}