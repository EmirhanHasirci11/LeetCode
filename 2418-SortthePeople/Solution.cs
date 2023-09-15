namespace SortthePeople
{
    internal class Solution
    {        
        public string[] SortPeople(string[] names, int[] heights)
        {
            string[] result=new string[names.Length];

            Dictionary<int, string> map = new();

            for(int i=0;i<names.Length;i++)
                map.Add(heights[i], names[i]);

            Array.Sort(heights);

            int index = 0;

            for(int i = heights.Length-1; i >= 0; i--)            
                result[index++] = map[heights[i]];
            
            return result;



            
        }
    }
}