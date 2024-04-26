namespace MinimumFallingPathSumII
{
    internal class Solution
    {        
        public int MinFallingPathSum(int[][] matrix)
        {
            int n = matrix.Length;

            for (int i = 1; i < n; i++)
            {
                int minVal = int.MaxValue, secondMinVal = int.MaxValue, minIndex = -1;

                // Find the minimum and second minimum values in the previous row
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i - 1][j] < minVal)
                    {
                        secondMinVal = minVal;
                        minVal = matrix[i - 1][j];
                        minIndex = j;
                    }
                    else if (matrix[i - 1][j] < secondMinVal)
                    {
                        secondMinVal = matrix[i - 1][j];
                    }
                }

                // Update the current row with the minimum sum for each cell
                for (int j = 0; j < n; j++)
                {
                    if (j != minIndex)
                    {
                        matrix[i][j] += minVal;
                    }
                    else
                    {
                        matrix[i][j] += secondMinVal;
                    }
                }
            }

            int minSum = int.MaxValue;
            foreach (int val in matrix[n - 1])
            {
                minSum = Math.Min(minSum, val);
            }

            return minSum;
        }
    }
}
