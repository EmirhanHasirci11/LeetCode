namespace MissingNumber
{
    internal class Program
    {        
        public int MissingNumber(int[] nums)
        {
            int xor = 0;
            foreach(int i in nums)
                xor ^= i;
            for(int i = 0; i < nums.Length; i++)
            {
                xor ^= nums[i];
            }
            return xor;
        }
    }
}