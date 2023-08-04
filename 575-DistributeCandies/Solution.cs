namespace DistributeCandies
{
    internal class Solution
    {
        public int DistributeCandies(int[] candyType)
        {
            HashSet<int> set = new(candyType);
            int candyLimit = candyType.Length/2;
            int currentCandyCount = 0;
            foreach(int candy in set)
            {
                if(currentCandyCount<candyLimit)
                    currentCandyCount++;
            }
            return currentCandyCount;
        }
    }
}