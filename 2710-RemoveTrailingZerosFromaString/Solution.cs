namespace RemoveTrailingZerosFromaString
{
    internal class Solution
    {        
        public string RemoveTrailingZeros(string num)
        {
            int countOfZeros = 0;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == '0')
                    countOfZeros++;
                else break;                
            }
                
            return num.Substring(0, num.Length-1-countOfZeros);
        }
    }
}