using System.Text;

namespace ConvertaNumbertoHexadecimal
{
    internal class Solution
    {

        private const string hex = "0123456789abcdef";

        public string ToHex(int num)
        {
            if (num == 0)
                return "0";

            var res = new StringBuilder();
            var n = num > 0 ? num : ((long)2 << 31) + num;

            while (n > 0)
            {
                res.Insert(0, hex[(int)(n % 16)]);
                n /= 16;
            }

            return res.ToString();
        }
    }
}