namespace MinimumLengthofStringAfterOperations
{
    internal class Solution
    {
        public int MinimumLength(string s)
        {
            var map = new int[26];
            var n = s.Length;
            var removed = 0;
            for (int i = 0; i < n; i++)
            {
                int ch = s[i] - 'a';
                map[ch]++;

                if (map[ch] == 3)
                {
                    map[ch] -= 2;
                    removed += 2;
                }
            }
            return n - removed;
        }
    }
}
