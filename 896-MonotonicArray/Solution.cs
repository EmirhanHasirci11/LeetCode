namespace MonotonicArray
{
    internal class Solution
    {        
        public bool IsMonotonic(int[] nums)
        {
            bool greater = false;
            bool lower = false;
            for(int i = 0; i < nums.Length-1; i++)
            {
                int substract = nums[i+1] - nums[i];
                if (substract > 0)
                    greater = true;
                else if(substract<0)
                    lower = true;
                if (lower && greater)
                    return false;
            }
            return true;
        }
    }
}