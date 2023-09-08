namespace ConsecutiveCharacters
{
    internal class Solution
    {        
        public int MaxPower(string s)
        {
           
            int maxUniqueSubstringCount =1;
            int currentUniqueSub = 1;
            char currentChar = s[0];
            for(int i = 1; i < s.Length; i++)
            {
                if (s[i] == currentChar)
                    currentUniqueSub++;
                else
                {
                    maxUniqueSubstringCount = Math.Max(currentUniqueSub, maxUniqueSubstringCount);
                    currentUniqueSub = 1;
                }
                currentChar = s[i];
            }
            return maxUniqueSubstringCount;
        }
    }
}