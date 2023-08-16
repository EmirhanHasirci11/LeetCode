using System.Collections.Generic;

namespace SortArraybyIncreasingFrequency
{
    internal class Solution
    {       
        public int[] FrequencySort(int[] nums)
        {
            Dictionary<int, int> keyValuePairs = new();
            foreach (int num in nums)
            {
                if (!keyValuePairs.ContainsKey(num))
                    keyValuePairs[num] = 1;
                else 
                    keyValuePairs[num]++;
            }
            var i = 0;
            foreach (var (value, frequency) in keyValuePairs.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                for (var j = 0; j < frequency; j++)
                {
                    nums[i++] = value;
                }
            }
            return nums;



        }
    }
}