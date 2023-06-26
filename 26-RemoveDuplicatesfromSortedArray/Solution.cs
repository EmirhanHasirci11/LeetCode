namespace RemoveDuplicatesfromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int control = 1;
            foreach (int number in nums)
            {
                if (nums[control - 1] != number)
                    nums[control++] = number;

            }
            return control;
        }
    }
}