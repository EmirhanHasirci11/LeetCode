namespace ContiguousArray
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> dict = new();
            dict[0] = -1;
            int zeros = 0, ones = 0, max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) zeros++; else ones++;
                int diff = zeros - ones;
                if (dict.ContainsKey(diff))
                    max = Math.Max(max, i - dict[diff]);
                else
                    dict.Add(diff, i);
            }

            return max;
        }

    }
}
