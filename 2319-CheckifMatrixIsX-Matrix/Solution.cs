namespace CheckifMatrixIsX_Matrix
{
    internal class Program
    {        
        public bool CheckXMatrix(int[][] grid)
        {
            int n = grid.Length;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col || row + col == n - 1)
                    {
                        if (grid[row][col] == 0) return false;
                    }
                    else
                    {
                        if (grid[row][col] != 0) return false;
                    }
                }
            }
            return true;
        }
    }
}