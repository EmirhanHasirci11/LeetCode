namespace LongestSubstringWithoutRepeatingCharacters
{
    internal class Program
    {        
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            Dictionary<char, int> map = new();
            int max = 0;
            for (int i = 0, j = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    j = Math.Max(j, map[s[i]] + 1);
                }
                map[s[i]] = i;
                max = Math.Max(max, i - j + 1);
            }
            return max;
        }
    }
}