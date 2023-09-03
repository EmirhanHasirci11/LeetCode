namespace PerfectNumber
{
    internal class Solution
    {        
        public bool CheckPerfectNumber(int num)
        {
            int sumOfDivisors = 0;
            for(int i=1;i<num/2;i++)
            {
                sumOfDivisors += num % i == 0 ? i:0;
            }
            return num == sumOfDivisors;
        }
    }
}