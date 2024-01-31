using System.Text;

namespace ReformatPhoneNumber
{
    internal class Solution
    {        
        public string ReformatNumber(string number)
        {
            StringBuilder sb = new();
            foreach (char c in number)
                if (char.IsDigit(c))
                    sb.Append(c);

            StringBuilder res = new();
            int idx = 0;
            while (idx < sb.Length)
            {
                int j = (sb.Length - idx == 4) ? idx + 2 : idx + 3;

                while (idx < sb.Length && idx < j)
                    res.Append(sb[idx++]);
                if (idx != sb.Length)
                    res.Append('-');
            }
            return res.ToString();
        }
    }
}