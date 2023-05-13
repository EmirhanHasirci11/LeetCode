namespace Sqrt_x_
{
    internal class Solution
    {       
        //Newton Method
        //iteration count must be dynamic but i cant find it how to do.
        public static int MySqrt(int x)
        {
            double root = 1;
            for (int i = 0; i <= 20; i++)
            {
                root = (x / root + root) / 2;
            }            
            return Convert.ToInt32(root.ToString().Split(".")[0]);
        }
    }
}