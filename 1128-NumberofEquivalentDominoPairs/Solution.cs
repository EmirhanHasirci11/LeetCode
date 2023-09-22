namespace NumberofEquivalentDominoPairs
{
    internal class Solution
    {        
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            Dictionary<int, int> map = new();
            int count = 0;
            foreach (int[] d in dominoes)
            {
                int key = Math.Min(d[0], d[1]) * 10 + Math.Max(d[0], d[1]);
                if (!map.TryAdd(key, 1))
                {
                    count += map[key];
                    map[key]++;
                }               
            }

            return count;
        }
    }
}