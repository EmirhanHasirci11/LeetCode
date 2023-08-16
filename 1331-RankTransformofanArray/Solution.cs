namespace RankTransformofanArray
{
    internal class Solution
    {       
        public int[] ArrayRankTransform(int[] arr)
        {
            PriorityQueue<(int index, int value), int> pq = new();
            int lengthOfArr = arr.Length;
            for(int i=0;i<lengthOfArr; i++)
            {
                pq.Enqueue((i, arr[i]), arr[i]);
            }
            int[] result= new int[lengthOfArr];
            int rank = 1;

            while (pq.Count > 0)
            {
                var currentValue = pq.Peek().value;

                while (pq.Count > 0 && pq.Peek().value == currentValue)
                {
                    var current = pq.Dequeue();
                    result[current.index] = rank;
                }

                rank++;
            }

            return result;
        }
    }
}