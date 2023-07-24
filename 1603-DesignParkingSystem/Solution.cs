namespace DesignParkingSystem
{
    public class ParkingSystem
    {
        Dictionary<int, int> emptySpace = new();
        public ParkingSystem(int big, int medium, int small)
        {
            emptySpace.Add(1, big);
            emptySpace.Add(2, medium);
            emptySpace.Add(3, small);
        }

        public bool AddCar(int carType)
        {
            if (emptySpace[carType] > 0)
            {
                emptySpace[carType]--;
                return true;
            }

            return false;
        }
    }
}