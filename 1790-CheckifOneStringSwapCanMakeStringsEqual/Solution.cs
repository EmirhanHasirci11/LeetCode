using System.Threading.Channels;

namespace CheckifOneStringSwapCanMakeStringsEqual
{
    internal class Solution
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            if (s1 == s2) return true;
            List<char> list1 = new();
            List<char> list2 = new();
            for (int i =0 ; i <s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    list1.Add(s1[i]);   
                    list2.Add(s2[i]);   
                }
            }
            foreach(char c in list1)
            {
                if (!list2.Contains(c))
                    return false;
            }
            return(list1.Count()==2&&list2.Count()==2)?true:false;
            
        }
    }
}