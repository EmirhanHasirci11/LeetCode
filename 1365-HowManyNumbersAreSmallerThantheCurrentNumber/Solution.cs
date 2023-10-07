namespace HowManyNumbersAreSmallerThantheCurrentNumber
{
    internal class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            int j = 0;
            while (j < nums.Length)
            {
                int countOfSmallerNumbers = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < nums[j])
                        countOfSmallerNumbers++;

                }
                result[j++]=countOfSmallerNumbers;
            }
            return result;

        }
    }
}