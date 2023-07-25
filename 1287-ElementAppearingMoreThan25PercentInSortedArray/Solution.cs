namespace ElementAppearingMoreThan25PercentInSortedArray
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public int FindSpecialInteger(int[] arr)
        {
            Dictionary<int, int> map = new();
            foreach (int val in arr)
            {
                if (map.ContainsKey(val))
                    map[val]++;
                else 
                    map[val] = 1;
            }
            int percent = arr.Length / 4;
            foreach(int key in map.Keys)
            {
                if (map[key] >= percent)
                    return key;
            };
            return 0;
        }
    }
}