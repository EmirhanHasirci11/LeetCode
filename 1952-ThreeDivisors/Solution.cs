namespace ThreeDivisors
{
    internal class Solution
    {        
        public bool IsThree(int n)
        {
            int countOfDivisors = 0;
            for(int i = 1; i <= n / 2; i++)            
                if(n%i==0)
                    countOfDivisors++;
            
            return countOfDivisors + 1==3?true:false;
        }
    }
}