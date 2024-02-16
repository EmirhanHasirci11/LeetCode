namespace LeastNumberofUniqueIntegersafterKRemovals
{
    internal class Solution
    {
        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            Dictionary<int, int> freq = new();

            foreach (int i in arr)
                if (!freq.TryAdd(i, 1))
                    freq[i]++;

            var sortedDict = freq.OrderBy(x => x.Value).ToList();
            foreach (var kvp in sortedDict)
            {
                if (k > 0)
                {
                    if (k >= kvp.Value)
                    {
                        k -= kvp.Value;
                        freq.Remove(kvp.Key);
                    }
                    else
                    {
                        freq[kvp.Key] -= k;
                        k = 0;
                    }
                }
                else
                    break;

            }


            return freq.Count;
        }
    }
}