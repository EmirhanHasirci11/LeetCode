namespace RemoveElement
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = { 3, 2, 2, 3 };
            Console.WriteLine(RemoveElement(nums, 3));
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int replacedIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]!=val)
                    nums[replacedIndex++] = nums[i];
            }
            return replacedIndex;
        }
    }

}