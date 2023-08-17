namespace CountCommonWordsWithOneOccurrence
{
    internal class Solution
    {       
        public int CountWords(string[] words1, string[] words2)
        {
            Dictionary<string, int> map = new();
            foreach(string word in words1)
            {
                if (!map.TryAdd(word, 1))
                    map[word]++;
            }
            foreach(string word in words2)
            {
                if (map.ContainsKey(word) && map[word]<=1)
                    map[word]--;
            }
            return map.Count(x => x.Value == 0);
        }
    }
}