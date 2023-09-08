namespace BinaryNumberwithAlternatingBits
{
    internal class Solution
    {        
        public bool HasAlternatingBits(int n)
        {
            string converted =Convert.ToString(n,2);

            for(int i = 1; i < converted.Length; i++)            
                if (converted[i - 1] == converted[i])
                    return false;
            
            return true;

        }
    }