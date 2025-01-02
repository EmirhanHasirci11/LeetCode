namespace CountVowelStringsinRanges
{
    internal class Solution
    {        
        public int[] VowelStrings(string[] words, int[][] queries)
        {
            int[] prefix = new int[words.Length + 1];
            int[] ans = new int[queries.Length];
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < words.Length; i++)
            {
                if (vowels.Contains(words[i][0]) && vowels.Contains(words[i][words[i].Length - 1]))
                {
                    prefix[i + 1] = prefix[i] + 1;
                    continue;
                }
                prefix[i + 1] = prefix[i];
            }

            for (var x = 0; x < queries.Length; x++)            
                ans[x] = prefix[queries[x][1] + 1] - prefix[queries[x][0]];
            
            return ans;
        }
    }
}
