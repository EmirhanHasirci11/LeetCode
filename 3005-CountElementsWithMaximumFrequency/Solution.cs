namespace CountElementsWithMaximumFrequency
{
    internal class Solution
    {        
        public int MaxFrequencyElements(int[] nums)
        {
            int result = 0;
            int max = int.MinValue;

            Dictionary<int, int> res = new();

            foreach(int i in nums)            
                if (!res.TryAdd(i, 1))
                    res[i]++;

            foreach(int val in res.Values)
                max = Math.Max(max, val);

            foreach (int val in res.Values)
                result += max == val ? max : 0;

            return result;

            
        }
    }
}