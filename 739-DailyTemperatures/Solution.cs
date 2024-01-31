namespace DailyTemperatures
{
    internal class Solution
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            Stack<int> stack= new ();
            int[] result = new int[temperatures.Length];
            for(int i=0;i<temperatures.Length;i++) 
            {
                while (stack.Count > 0 && (temperatures[i] > temperatures[stack.Peek()]))
                {
                    int idx = stack.Pop();
                    result[idx] = i-idx;
                }
                stack.Push(i);
            }
            return result;
        }
    }
}