namespace CountNegativeNumbersinaSortedMatrix
{
    internal class Solution
    {        
        public int CountNegatives(int[][] grid)
        {
            int countOfNegatives =0;
            for(int i=0;i<grid.Length;i++)
            {
                for(int j = grid[i].Length-1;j>=0;j--)
                {
                    if (grid[i][j]<0)
                        countOfNegatives++;
                    else
                        break;
                }
            }
            return countOfNegatives;
        }
    }
}