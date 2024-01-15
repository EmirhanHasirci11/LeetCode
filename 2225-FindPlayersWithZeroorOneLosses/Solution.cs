namespace FindPlayersWithZeroorOneLosses
{
    internal class Solution
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            
            var map = new SortedDictionary<int, int>();
            foreach (int[] match in matches)
            {
                map.TryAdd(match[0], map.GetValueOrDefault(match[0], 0));
                map.TryAdd(match[1], map.GetValueOrDefault(match[1], 0) + 1);
            };
                
            List<IList<int>> list = new() { new List<int>(), new List<int>() };
            foreach (int player in map.Keys)
                if (map[player] <= 1)
                    list[map[player]].Add(player);
            return list;
            

        }
    }
}