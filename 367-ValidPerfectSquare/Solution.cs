namespace ValidPerfectSquare
{
    internal class Solution
    {        
        public bool IsPerfectSquare(int num)
        {
            long a = 1;
            long b = num;
            while (a <= b)
            {
                long mid = a + (b - a) / 2;
                long mult = mid * mid;
                if (mult > num)
                    b = mid - 1;
                else if (mult < num)
                    a = mid + 1;
                else return true;
            }
            return false;
        }
}