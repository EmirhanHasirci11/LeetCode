namespace FindtheHighestAltitude
{
    internal class Program
    {        
        public static int LargestAltitude(int[] gain)
        {
            int maxAltitude = int.MinValue;
            int sum = 0;
            foreach(int i in gain)
            {
                sum+= i;
                if(sum > maxAltitude)
                {
                    maxAltitude = sum;
                }
            }
            return maxAltitude>0?maxAltitude:0;
        }
    }
}