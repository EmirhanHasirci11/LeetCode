using System.Text;

namespace ThousandSeparator
{
    internal class Solution
    {        
        public string ThousandSeparator(int n)
        {
            if (n.ToString().Length <= 3) return n.ToString();
            StringBuilder sb = new StringBuilder();
            int count = 1;
            while(n> 0)
            {
                sb.Insert(0, n%10);
                if (count % 3 == 0)
                    sb.Insert(0, '.');
                n /= 10;
                count++;
            }
            
            return sb[0]=='.'?sb.ToString().Substring(1):sb.ToString();
        }
    }
}