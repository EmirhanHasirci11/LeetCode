namespace CheckifAllCharactersHaveEqualNumberofOccurrences
{
    internal class Solution
    {
        public bool AreOccurrencesEqual(string s)
        {
            Dictionary<char, int> map = new();

            foreach (char c in s)
                if (!map.TryAdd(c, 1))
                    map[c]++;

            int countOfFirstC = map[s[0]];

            foreach (int val in map.Values)
                if (val != countOfFirstC)
                    return false;

            return true;
        }
    }
}