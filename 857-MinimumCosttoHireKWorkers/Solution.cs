namespace MinimumCosttoHireKWorkers
{
    internal class Solution
    {        
        public double MincostToHireWorkers(int[] quality, int[] wage, int k)
        {
            List<(int, double)> ratio = new List<(int, double)>();
            int len = quality.Length;
            for (int i = 0; i < len; i++)
            {
                ratio.Add((quality[i], (double)wage[i] / (double)quality[i]));
            }

            ratio = ratio.OrderBy(x => x.Item2).ToList();

            int totQuantity = 0;
            double result = 0;
            PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
            for (int i = 0; i < len; i++)
            {
                heap.Enqueue(ratio[i].Item1, -1 * ratio[i].Item1);
                totQuantity += ratio[i].Item1;

                if (i + 1 >= k)
                {
                    result = result == 0 ? (totQuantity * ratio[i].Item2) : Math.Min(result, totQuantity * ratio[i].Item2);
                    totQuantity -= heap.Dequeue();
                }
            }

            return result;
        }
    }
}
