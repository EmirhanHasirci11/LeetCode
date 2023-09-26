namespace FindLuckyIntegerinanArray
{
    internal class Solution
    {
        public int FindLucky(int[] arr)
        {
            int result = -1;
            Dictionary<int, int> map = new();
            foreach (int i in arr)            
                if (!map.TryAdd(i, 1))
                    map[i]++;
            foreach(int key in map.Keys)
                if (key == map[key]&&key>result)
                    result= map[key];
            return result;

            
        }
    }
}