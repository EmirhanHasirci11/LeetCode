namespace SorttheStudentsbyTheirKthScore
{
    internal class Solution
    {        
        public int[][] SortTheStudents(int[][] score, int k)
        {
            int studentCount=score.Length;
            int examCount = score[0].Length;
            List<(int score,int index)> kCol=new();
            for(int i=0;i<studentCount;i++)
            {
                kCol.Add(new(score[i][k], i));
            }
            kCol.Sort((x, y) => y.score.CompareTo(x.score));
            int[][] result = new int[studentCount][];
            for(int i=0;i<studentCount ;i++) 
            {
                result[i]=new int[examCount];
                for (int j = 0; j < examCount; j++)
                    result[i][j] = score[kCol[i].index][j];
            }
            return result;
        }
    }
}