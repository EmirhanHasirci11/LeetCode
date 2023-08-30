namespace PercentageofLetterinString
{
    internal class Solution
    {        
        public int PercentageLetter(string s, char letter)
        {
            int count = 0;
            int lengthOfs = s.Length;
            for(int i = 0; i < lengthOfs; i++)
            {
                if (s[i] == letter)
                    count++;
            }
            return count == 0 ? 0 :(count*100)/lengthOfs;
        }
    }
}