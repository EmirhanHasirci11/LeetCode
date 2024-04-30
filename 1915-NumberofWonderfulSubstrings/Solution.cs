namespace NumberofWonderfulSubstrings
{
    internal class Solution
    {
        public long WonderfulSubstrings(string word)
        {
            var freq = new long[1024];
            freq[0] = 1;
            long result = 0; 
            var mask = 0;
            foreach (var ch in word)
            {
                mask ^= MaskOf(ch);
                result += freq[mask];                
                for (var curr = 'a'; curr <= 'j'; curr++)
                {
                    var maskToCheck = mask ^ MaskOf(curr);
                    result += freq[maskToCheck];
                }

               
                freq[mask]++;
            }

            return result;
        }

        private int MaskOf(char ch)
        {           
            var val = ch - 'a';
            return 1 << val;
        }
    
    }
}
