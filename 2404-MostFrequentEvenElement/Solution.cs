namespace MostFrequentEvenElement
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            MostFrequentEven(new int[] { 0, 1, 2, 2, 4, 4, 1 });
        }
        public static int MostFrequentEven(int[] nums)
        {
            int evenKey = -1;
            int frequency = 0;
            Dictionary<int, int> map = new();
            foreach (int val in nums)
            {
                if (val % 2 == 0)
                    if (!map.TryAdd(val, 1))
                        map[val]++;
            }
            foreach(int key in map.Keys)
            {
                if (map[key] > frequency)
                {
                    frequency = map[key];
                    evenKey= key;
                }
               else if (map[key] == frequency && key < evenKey)
                    evenKey= key;
                
            }
            return evenKey;
        }
    }
}