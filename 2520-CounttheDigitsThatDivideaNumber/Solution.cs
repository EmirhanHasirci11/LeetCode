namespace CounttheDigitsThatDivideaNumber
{
    internal class Solution
    {        
        public int CountDigits(int num)
        {
            int tempOfNum = num;
            int countOfDivisibleDigit = 0;
            while (tempOfNum > 0)
            {
                if(num%(tempOfNum%10)==0)
                    countOfDivisibleDigit++;
                tempOfNum /= 10;
            }
            return countOfDivisibleDigit;
        }
    }
}