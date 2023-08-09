namespace PowerofFour
{
    internal class Solution
    {
        public bool IsPowerOfFour(int n)
        {
            int powerOfFour = 0;
            while (Math.Pow(4,powerOfFour)!=n)
            {
                if (Math.Pow(4,powerOfFour)>n)
                    return false;
                powerOfFour++;
            }
            return true;
        }
    }
}