namespace Pascal_sTriangleII
{
    internal class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {

            List<int> prev = new List<int>() { 1 };
            for (int i = 0; i < rowIndex; i++)
            {
                List<int> current = new();
                current.Add(1);
                for (int j = 1; j < prev.Count; j++)
                {
                    current.Add(prev[j] + prev[j-1]);
                }
                current.Add(1);
                prev = current;
            }
            return prev;
        }
    }
}