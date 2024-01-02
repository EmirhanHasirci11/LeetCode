namespace ConvertanArrayIntoa2DArrayWithConditions
{
    internal class Solution
    {       
        public IList<IList<int>> FindMatrix(int[] nums)
        {
            List<int> ints=nums.ToList();
            List<IList<int>> res = new();            
            HashSet<int> visited = new();            
            while (ints.Count!=0) 
            {
                List<int> temp = new ();
                for(int i=0;i<ints.Count;i++)
                {
                    if (!visited.Contains(ints[i]))
                    {
                        visited.Add(ints[i]);
                        temp.Add(ints[i]);
                        ints.RemoveAt(i);
                        i--;
                    }
                }
                res.Add(temp);
                visited.Clear();
            }
            return res;

        }
    }
}