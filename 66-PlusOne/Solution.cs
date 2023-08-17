namespace PlusOne
{
    internal class Solution
    {        
        public int[] PlusOne(int[] digits)
        {
            int lengthOfDigits = digits.Length;            
            for (int i = lengthOfDigits - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newNumber = new int[lengthOfDigits + 1];
            newNumber[0] = 1;

            return newNumber;
        }
    }
}