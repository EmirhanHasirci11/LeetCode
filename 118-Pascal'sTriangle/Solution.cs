namespace Pascal_sTriangle
{
    internal class Solution
    {        
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> result = new();
            result.Add(new List<int>() { 1});
            for(int i = 1; i < numRows; i++)
            {
                List<int> temp = new();
                temp.Add(1); 
                for(int j = 1; j < i; j++)
                {
                    int number = result[i - 1][j - 1] + result[i - 1][j];
                    temp.Add(number);
                }
                temp.Add(1);
                result.Add(temp);

            }
            return result;
        }
    }
}