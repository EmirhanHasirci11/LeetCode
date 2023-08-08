namespace CountIntegersWithEvenDigitSum
{
    internal class Solution
    {
        public int CountEven(int num)
        {
            int result = 0;
            while (num > 0)
            {
                int digit = num;
                int sum = 0;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }
                num--;
                if (sum % 2 == 0)
                    result++;
            }
            return result;
        }
    }
}