using System.Text;

namespace PrimeNumberofSetBitsinBinaryRepresentation
{
    internal class Solution
    {       
        public int CountPrimeSetBits(int left, int right)
        {
            StringBuilder sb = new();
            int count = 0;
            while(left<=right)
            {
                int countOfSetBit = 0;
                sb.Append(Convert.ToString(left++,2));
                foreach (char c in sb.ToString())
                    countOfSetBit += c == '1' ? 1 : 0;
                count += isPrime(countOfSetBit) ? 1 : 0;
                sb.Clear();
            }
            return count;
        }
        private bool isPrime(int num)
        {
            if(num==2) return true;
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0)
                    return false;
            return true;
        }
    }
}