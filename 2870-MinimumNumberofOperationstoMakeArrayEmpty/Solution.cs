namespace MinimumNumberofOperationstoMakeArrayEmpty
{
    internal class Solution
    {
        public int MinOperations(int[] nums)
        {
            Dictionary<int, int> map = new();
            foreach (int num in nums)            
                if (!map.TryAdd(num, 1))
                    map[num]++;
            
            int totalMinimumOperationCount = 0;
            foreach(int key in map.Keys)
            {
                int valueOfKey = map[key];

                if (valueOfKey == 1)
                    return -1;
                totalMinimumOperationCount+=valueOfKey/3;
                if(valueOfKey%3!=0)
                    totalMinimumOperationCount++;
            }
            return totalMinimumOperationCount;
        }
    }
}