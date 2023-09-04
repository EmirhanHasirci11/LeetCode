namespace WaterBottles
{
    internal class Solution
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            int amountOfDrinkedBottle = numBottles;
            int emptyBottles = 0;

            while (numBottles >= numExchange)
            {
                emptyBottles = numBottles % numExchange;
                numBottles -= emptyBottles;
                amountOfDrinkedBottle += numBottles / numExchange;
                numBottles = (numBottles / numExchange) + emptyBottles;

            }
            return amountOfDrinkedBottle;
        }
    }
}