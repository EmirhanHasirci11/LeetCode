namespace UniqueNumberofOccurrences
{
    internal class Solution
    {        
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> map = new();
            foreach(int num in arr)
            {
                if (!map.TryAdd(num, 1))
                    map[num]++;
            }
            HashSet<int> set = new(map.Values);
            return map.Count() == set.Count();
        }
    }
}