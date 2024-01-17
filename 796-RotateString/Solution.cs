using System.Text;

namespace RotateString
{
    internal class Solution
    {        
        public bool RotateString(string s, string goal)
        {
            StringBuilder sb= new (s);
            for(int i=0;i<s.Length;i++)
            {
                sb.Insert(0, s[s.Length-1]);
                sb.Remove(sb.Length-1,1);
                if(sb.ToString().Equals(goal))
                    return true;
                s=sb.ToString();
            }
            return false;
        }
    }
}