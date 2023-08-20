namespace SumofDigitsinBaseK
{
    internal class Solution
    {        
        public int SumBase(int n, int k)
        {
            int sumOfConvertedDigits = 0;
            while (n > 0)
            {
                sumOfConvertedDigits+= n%k;
                n/= k;
            }                  
            return sumOfConvertedDigits;
        }
    }
}