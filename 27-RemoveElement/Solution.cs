namespace RemoveElement
{
    internal class Solution
    {        
        public static int RemoveElement(int[] nums, int val)
        {
            int replacedIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                    nums[replacedIndex++] = nums[i];
            }
            return replacedIndex;
        }
    }

}