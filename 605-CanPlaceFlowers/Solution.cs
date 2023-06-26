namespace CanPlaceFlowers
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            int[] flowerbed = { 1, 0, 1, 0, 1, 0, 1 };
            Console.WriteLine(CanPlaceFlowers(flowerbed, 1));
        }
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length && n > 0; i++)
            {
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) &&
                    (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    i++;
                    n--;
                }
            }
            return n == 0;
        }
    }
}