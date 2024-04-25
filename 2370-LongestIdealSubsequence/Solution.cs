namespace LongestIdealSubsequence
{
    internal class Solution
    {
        public int LongestIdealString(string s, int k)
        {
            int[] dp = new int[26];
            int curr = 0;
            int longest = 0;
            foreach (char c in s)
            {
                curr = c - 'a';
                longest = 1;
                for (int i = 0; i < 26; i++)
                {
                    if (Math.Abs(curr - i) <= k)
                        longest = Math.Max(longest, 1 + dp[i]);
                }
                dp[curr] = Math.Max(dp[curr], longest);
            }
            return dp.Max();
        }
    }
}
