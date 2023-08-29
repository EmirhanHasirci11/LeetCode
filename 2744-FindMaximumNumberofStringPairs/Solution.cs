namespace FindMaximumNumberofStringPairs
{
    internal class Solution
    {        
        public int MaximumNumberOfStringPairs(string[] words)
        {
            Dictionary<string, bool> map = new();
            foreach (string word in words)
            {
                if (map.ContainsKey("" + word[1] + word[0]) || map.ContainsKey(word))
                {
                    if (!map.TryGetValue(word, out bool val))
                        map["" + word[1] + word[0]] = true;

                    else
                        map[word] = true;
                }
                else map[word] = false;
            }
            return map.Where(x => x.Value == true).Count();
        }
    }
}