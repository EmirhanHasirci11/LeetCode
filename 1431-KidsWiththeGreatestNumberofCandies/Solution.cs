namespace KidsWiththeGreatestNumberofCandies
{
    internal class Solution
    {        
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new();
            int maxCandyCount = candies.Max(); ;
            foreach(int candy in candies){
                if (candy + extraCandies >= maxCandyCount)
                    result.Add(true);
                else
                    result.Add(false);
            }
            return result;
        }
    }
}