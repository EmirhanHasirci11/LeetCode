namespace MatrixDiagonalSum
{
    internal class Solution
    {        
        public int DiagonalSum(int[][] mat)
        {            
            int sumOfDiagonals = 0;
            for(int i=0;i<mat.Length;i++)
            {
                sumOfDiagonals+= mat[i][i] + mat[i][mat.Length-1-i];
            }
            if(mat.Length % 2!=0)
                sumOfDiagonals -= mat[(mat.Length - 1)/2][(mat.Length - 1) / 2];
            return sumOfDiagonals;
        }
    }
}