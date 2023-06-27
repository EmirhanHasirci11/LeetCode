using System.Collections.Generic;

namespace ContainsDuplicate
{
    internal class Solution
    {
       
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            return nums.Length > set.Count;
        }
    }
}