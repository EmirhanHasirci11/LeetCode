namespace CountingWordsWithaGivenPrefix
{
    internal class Solution

    {
        public int PrefixCount(string[] words, string pref)
        {
            int countOfPrefixMatch = 0;
            foreach (var word in words)
            {
                if(word.StartsWith(pref, StringComparison.OrdinalIgnoreCase))
                    countOfPrefixMatch++;
            }
            return countOfPrefixMatch;
        }
    }
}
