namespace MaximumCandiesYouCanGetfromBoxes
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes)
        {
            int res = 0;
            Queue<int> q = new Queue<int>();

            foreach (int i in initialBoxes)
            {
                status[i] += 5000;
                if (status[i] > 5000)
                    q.Enqueue(i);
            }

            while (q.Count > 0)
            {
                int b = q.Dequeue();
                res += candies[b];

                foreach (int i in keys[b])
                {
                    status[i] += 5;
                    if (status[i] == 5005)
                        q.Enqueue(i);
                }

                foreach (int i in containedBoxes[b])
                {
                    status[i] += 5000;
                    if (status[i] > 5000)
                        q.Enqueue(i);
                }
            }

            return res;
        }
    }
}
