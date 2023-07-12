namespace JewelsandStones
{
    internal class Solution
    {       
        public int NumJewelsInStones(string jewels, string stones)
        {
            int countOfJewelStones = 0;
            HashSet<char> charHash = new HashSet<char>(jewels);
            foreach (char c in stones)
            {
                if(charHash.Contains(c))
                    countOfJewelStones++;
            }
            return countOfJewelStones;

        }
    }
}