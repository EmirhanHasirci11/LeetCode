namespace ReverseString
{
    internal class Solution
    {       
        public void ReverseString(char[] s)
        {
            int halfLengthOfS = s.Length % 2 == 0 ? s.Length / 2 : (s.Length - 1) / 2;
            for(int i=0;i<halfLengthOfS;i++)
            {
                char temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i]= temp;
            }           
        }
    }
}