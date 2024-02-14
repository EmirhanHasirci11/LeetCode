namespace RearrangeArrayElementsbySign
{
    public class Solution
    {
        public int[] RearrangeArray(int[] nums)
        {
            int[] res = new int[nums.Length];
            int index = 0, pi = 0, ni = 1;
            while (index < nums.Length)
            {
                if (nums[index] >0) 
                {
                    res[pi] = nums[index++];
                    pi+=2;
                }
                else
                {
                    res[ni] = nums[index++];
                    ni += 2;
                }
            }
            return res;
        }
    }
}