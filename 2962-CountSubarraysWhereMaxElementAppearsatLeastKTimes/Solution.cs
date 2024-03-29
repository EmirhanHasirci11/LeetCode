using System.Xml.Linq;

namespace CountSubarraysWhereMaxElementAppearsatLeastKTimes
{
    internal class Solution
    {        
        public long CountSubarrays(int[] nums, int k)
        {
            long arrayLength = nums.Length;
            long maxElement = nums.Max();
            long leftIndex = 0, rightIndex = 0, maxElementCount = 0, subarrayCount = 0;

            while (rightIndex < arrayLength)
            {
                if (nums[rightIndex] == maxElement)
                {
                    maxElementCount++;
                }
                if (maxElementCount >= k)
                {
                    while (maxElementCount >= k)
                    {
                        subarrayCount += arrayLength - rightIndex;
                        if (nums[leftIndex] == maxElement)
                        {
                            maxElementCount--;
                        }
                        leftIndex++;
                    }
                }
                rightIndex++;
            }
            return subarrayCount;
        }
    }
}
