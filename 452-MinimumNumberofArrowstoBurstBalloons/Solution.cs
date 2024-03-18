namespace MinimumNumberofArrowstoBurstBalloons
{
    internal class Solution
    {        
        public int FindMinArrowShots(int[][] points)
        {
            Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));

            int arrows = 1;
            int prevEnd = points[0][1];

            // Count the number of non-overlapping intervals
            for (int i = 1; i < points.Length; ++i)
            {
                if (points[i][0] > prevEnd)
                {
                    arrows++;
                    prevEnd = points[i][1];
                }
            }

            return arrows;
        }
    }
}
