using System.Linq;

namespace FindAllGroupsofFarmland
{
    internal class Solution
    {        
        public int[][] FindFarmland(int[][] land)
        {
            List<int[]> result = new List<int[]>();

            int m = land.Length;
            int n = land[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (land[i][j] == 1)
                    {
                        int[] coordinates = FindFarmlandCoordinates(land, i, j);
                        result.Add(coordinates);
                    }
                }
            }

            return result.ToArray();
        }
        public int[] FindFarmlandCoordinates(int[][] land, int row, int col)
        {
            int[] coordinates = new int[4];
            coordinates[0] = row;
            coordinates[1] = col;

            int m = land.Length;
            int n = land[0].Length;

            int r = row;
            int c = col;
            
            while (r < m && land[r][col] == 1) r++;
            while (c < n && land[row][c] == 1) c++;
            coordinates[2] = r - 1;
            coordinates[3] = c - 1;

            for (int i = row; i < r; i++)
            {
                for (int j = col; j < c; j++)
                {
                    land[i][j] = 0;
                }
            }

            return coordinates;
        }
    }
}
