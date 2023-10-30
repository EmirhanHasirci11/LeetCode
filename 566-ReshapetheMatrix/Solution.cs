namespace ReshapetheMatrix
{
    internal class Solution
    {        
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int rows = mat.Length;
            int cols = mat[0].Length;
            if (cols * rows != r * c) return mat;

            int[][] output = new int[r][];           
            int resultRow = 0;
            int resultCol = 0;
            for (int i = 0; i < r; i++)
            {
                output[i] = new int[c];
            }
            for (int i = 0; i < rows; i++)
            {
              
                for(int j = 0; j < cols; j++)
                {
                    output[resultRow][resultCol] = mat[i][j];
                    resultCol++;
                    if(resultCol == c) 
                    {
                        resultCol= 0;
                        resultRow++;
                    }
                }
            }
            return output;
        }
    }
}