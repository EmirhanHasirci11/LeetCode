using System.Text;

namespace RemoveKDigits
{
    internal class Solution
    {
        public string RemoveKdigits(string num, int k)
        {
            if (k == num.Length)
                return "0";

            StringBuilder ms = new();

            foreach (char c in num)
            {
                while (k > 0 && ms.Length > 0 && ms[^1] > c)
                {
                    ms.Length--;
                    k--;
                }
                ms.Append(c);
            }

            ms.Length -= k;
            string result = ms.ToString().TrimStart('0');
            return result.Length == 0 ? "0" : result;
        }
    }
}
