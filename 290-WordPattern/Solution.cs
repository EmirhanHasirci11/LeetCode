namespace WordPattern
{
    internal class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] sArray = s.Split();

            if (pattern.Length != sArray.Length)
                return false;

            Dictionary<char, string> map = new();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (map.ContainsKey(pattern[i]))
                {
                    if (map[pattern[i]] != sArray[i]) return false;
                }
                else
                {
                    if (map.ContainsValue(sArray[i])) return false;
                    map.Add(pattern[i], sArray[i]);
                }
            }
            return true;
        }
    }
}