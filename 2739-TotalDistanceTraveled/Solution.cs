namespace TotalDistanceTraveled
{
    internal class Solution
    {
        public int DistanceTraveled(int mainTank, int additionalTank)
        {
            int usedFuelCount = 0;
            int totalDistance = 0;
            while (mainTank> 0)
            {
                totalDistance += 10;
                usedFuelCount++;
                mainTank--;
                if (usedFuelCount==5 && additionalTank>0)
                {
                    mainTank++;
                    additionalTank--;
                    usedFuelCount = 0;
                }
            }
            return totalDistance;
        }
    }
}