namespace SequentialDigits
{
    internal class Solution
    {        
        public IList<int> SequentialDigits(int low, int high)
        {
            List<int> res = new();
            Queue<int> queue = new Queue<int>();
            for(int i=1;i<10;i++)            
                queue.Enqueue(i);

            while (queue.Count != 0)
            {
                int n=queue.Dequeue();
                if (n > high)
                    continue;
                if(low<=n&&n<=high)
                    res.Add(n);
                int ones = n % 10;
                if (ones < 9)
                    queue.Enqueue(n * 10 + (ones + 1));
            }
            return res;
            
        }
    }
}