using System.Text;

namespace UniqueEmailAddresses
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            NumUniqueEmails(new string[] { "test.email+alex@leetcode.com", "test.email.leet+alex@code.com" });
        }
        public static int NumUniqueEmails(string[] emails)
        {
            Dictionary<string, int> map = new();
            foreach (string mail in emails)
            {
                StringBuilder sb = new();
                bool flag = false;
                for (int i = 0; i < mail.Length; i++)
                {
                    if (mail[i] == '.')
                        continue;
                    if (mail[i] == '+')
                        flag = true;
                    else if (mail[i] == '@')
                    {
                        sb.Append(mail.Substring(i));
                        break;
                    }
                    if (!flag)
                        sb.Append(mail[i]);
                }
                if(map.TryAdd(sb.ToString(),1))
                    map[sb.ToString()]++;
            }
            return map.Count;
        }
    }
}