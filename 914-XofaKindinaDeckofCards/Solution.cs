namespace XofaKindinaDeckofCards
{
    internal class Solution
    {        
        public bool HasGroupsSizeX(int[] deck)
        {            
            Dictionary<int, int> map = new();
            foreach (int i in deck)
            {
                if (!map.TryAdd(i, 1))
                    map[i]++;
            }
            int minimumPairCount = 0;
            foreach (int mapValues in map.Values)
            {
                minimumPairCount = GCD(minimumPairCount, mapValues);
                if (minimumPairCount < 2) return false;
            }
            return true;
        }
        private int GCD(int a, int b)
        {
            if (b > a) return GCD(b, a);
            if (a % b == 0) return b;
            return GCD(b, a % b);
        }
    }
}