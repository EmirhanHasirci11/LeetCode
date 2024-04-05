using System.Text;

namespace MakeTheStringGreat
{
    internal class Solution
    {        
        public string MakeGood(string s)
        {
            var sb = new StringBuilder();
            foreach (var c in s)
                if (sb.Length > 0 && Math.Abs(sb[^1] - c) == 32)
                    sb.Length--;
                else
                    sb.Append(c);
            return sb.ToString();
        }
    }
}
