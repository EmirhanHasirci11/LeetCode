namespace AlternatingDigitSum
{
    internal class Solution
    {       
        public int AlternateDigitSum(int n)
        {
            string s = "" + n;

            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0) total += s[i] - '0';
                else total -= s[i] - '0';
            }

            return total;
        }
    }
}