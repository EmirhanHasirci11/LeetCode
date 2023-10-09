using System.Text;

namespace SubstringsofSizeThreewithDistinctCharacters
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            CountGoodSubstrings("aababcabc");
        }
        public static int CountGoodSubstrings(string s)
        {
            int result = 0;
            for(int i=0;i<s.Length-2;i++) 
            {
                string temp= s.Substring(i, 3);
                temp = string.Concat(temp.OrderBy(x => x));
                for(int j=0;j<temp.Length-1;j++)
                {
                    if (temp[j] == temp[j + 1]) break;
                    if (j == 1) result++;
                }                                
            }
            return result;
        }
    }
}