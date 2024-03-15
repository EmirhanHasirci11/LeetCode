namespace ProductofArrayExceptSelf
{
    internal class Solution
    {        
        public int[] ProductExceptSelf(int[] nums)
        {
            int lengthOfNums = nums.Length;
            int[] res=new int[lengthOfNums];

            int left=1; int right=1;
            for(int i = 0; i < lengthOfNums; i++)
            {
                if(i>0)
                    left*= nums[i-1];
                res[i] = left;
            }
            for (int i = lengthOfNums - 1; i >= 0; i--)
            {
                if (i < lengthOfNums - 1)
                    right *= nums[i + 1];
                res[i] *= right;
            }
            return res;
        }
    }
}