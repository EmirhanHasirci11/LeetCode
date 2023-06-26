namespace SingleNumber
{
    internal class Solution
    {        
        public int SingleNumber(int[] nums)
        {
            int sum = 0;            
            foreach (int i in nums)            
                sum ^=  i;
            
            return sum;
        }
    }
}