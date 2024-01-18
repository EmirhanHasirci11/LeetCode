using System.Text;

namespace BackspaceStringCompare
{
    internal class Solution
    {        
        public bool BackspaceCompare(string s, string t)
        {
            string first = ResultString(s);
            string second = ResultString(t);
            return first == second;
        }
        public string ResultString(string temp)
        {
            StringBuilder sb = new (temp);
            int index = 0;
            while (index < sb.Length - 1)
            {
                if (sb[index + 1] == '#')
                {
                    sb.Remove(index, 2);
                    index = 0;
                    continue;
                }
                index++;
            }
            sb.Replace("#","");
            
            return sb.ToString();
        }
    }
}