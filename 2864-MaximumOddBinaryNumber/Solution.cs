using System.Text;

namespace MaximumOddBinaryNumber
{
    internal class Solution
    {
        public string MaximumOddBinaryNumber(string s)
        {            
            int onesCount = 0;
            for (int i = 0; i < s.Length; i++)            
                onesCount += s[i] - '0';
            
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < onesCount - 1; i++)            
                result.Append("1");
            
            for (int i = 0; i < s.Length - onesCount; i++)            
                result.Append("0");
            
            result.Append("1");
            return result.ToString();

        }
    }
}