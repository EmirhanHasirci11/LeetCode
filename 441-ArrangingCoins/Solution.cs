namespace ArrangingCoins
{
    internal class Solution
    {
        public int ArrangeCoins(int n)
        {
            int stair = 1;
            int completedRows = 0;
            while (n-stair >= 0)
            {
                completedRows++;
                n -= stair;
                stair++;
                
            }
            return completedRows;
        }
    }
}