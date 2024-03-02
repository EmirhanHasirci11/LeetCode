namespace CheckWhetherTwoStringsareAlmostEquivalent
{
    internal class Solution
    {        
        public bool CheckAlmostEquivalent(string word1, string word2)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < word1.Length; i++)
            {
                char char1 = word1[i];
                char char2 = word2[i];
                map[char1] = map.GetValueOrDefault(char1, 0) + 1;
                map[char2] = map.GetValueOrDefault(char2, 0) - 1;
            }
            foreach (int value in map.Values)
            {
                if (value > 3 || value < -3)
                {
                    return false;
                }
            }
            return true;

        }
    }
}