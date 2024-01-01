namespace AssignCookies
{
    internal class Solution
    {     
        public int FindContentChildren(int[] g, int[] s)
        {
            if(s.Length== 0) return 0;
            Array.Sort(s);
            Array.Sort(g);
            int countOfHappyChild = 0;
            int lengthOfChild = g.Length - 1;
            int lengthOfCookies = s.Length - 1;
            while(lengthOfCookies >= 0 && lengthOfChild>=0)
            {
                if (s[lengthOfCookies] >= g[lengthOfChild]) 
                {
                    countOfHappyChild++;
                    lengthOfCookies--;
                    lengthOfChild--;
                }
                else
                {
                    lengthOfChild--;
                }

            }
            return countOfHappyChild;
        }
    }
}