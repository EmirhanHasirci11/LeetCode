namespace FindGreatestCommonDivisorofArray
{
    public class Solution
    {
        static void Main(string[] args)
        {
            FindGCD(new int[] { 252,105 });
        }
        public static int FindGCD(int[] nums)
        {            
            return gcd(nums.Min(), nums.Max()); 
        }
        private static int gcd(int a,int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }
    }
}