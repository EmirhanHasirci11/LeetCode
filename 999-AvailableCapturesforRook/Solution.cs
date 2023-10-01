namespace RowWithMaximumOnes
{
    internal class Solution
    {        
        public int[] RowAndMaximumOnes(int[][] mat)
        {
            int minIndex = 0;
            int maximumOnesCount = 0;
            for(int i=0;i<mat.Length;i++)
            {
                int tempCount = 0;                
                for (int j =0; j < mat[i].Length;j++)                
                    if (mat[i][j]==1)
                        tempCount++;
                
                if(tempCount > maximumOnesCount) 
                {
                    minIndex= i;
                    maximumOnesCount = tempCount;
                }
            }
            return new[] {minIndex,maximumOnesCount};
        }
    }
}