namespace AverageValueofEvenNumbersThatAreDivisiblebyThree
{
    internal class Solution
    {
        
        public int AverageValue(int[] nums)
        {
            int sum = 0;
            int count = 0;
            foreach(int val in nums)            
                if (val % 6 == 0)
                {
                    sum += val;
                    count++;
                }                           
            return sum!=0? sum / count:0;
        }
    }
}