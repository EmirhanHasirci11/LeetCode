using System.Numerics;

namespace FindAllDuplicatesinanArray
{
    internal class Solution
    {
        
        public IList<int> FindDuplicates(int[] nums)
        {
            if (nums.Length==0) return null;
            List<int> ans=new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i]) - 1] < 0)
                    ans.Add(Math.Abs(nums[i]));
                nums[Math.Abs(nums[i]) - 1] = -nums[Math.Abs(nums[i]) - 1];
            }
            return ans;
        }
    }
}
