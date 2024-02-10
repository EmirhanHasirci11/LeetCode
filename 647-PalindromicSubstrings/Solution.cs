namespace PalindromicSubstrings
{
    internal class Solution
    {        
        public int CountSubstrings(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                count += expand(s, i, i);
                count += expand(s, i, i + 1);
            }
            return count;
        }
        private int expand(String s, int left, int right)
        {
            int n = s.Length, count = 0;
            while (left >= 0 && right < n && s[left] == s[right])
            {
                count++;
                left--;
                right++;
            }
            return count;
        }
    }
}