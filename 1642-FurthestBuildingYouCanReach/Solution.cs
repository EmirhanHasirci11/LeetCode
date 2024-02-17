namespace FurthestBuildingYouCanReach
{
    internal class Solution
    {
        public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            PriorityQueue<int, int> priorityQueue = new();
            for (int index = 0; index < heights.Length - 1; index++)
            {
                int heightDifference = heights[index + 1] - heights[index];
                if (heightDifference <= 0) continue;
                bricks -= heightDifference;
                priorityQueue.Enqueue(heightDifference, -heightDifference);

                if (bricks < 0)
                {
                    if (ladders == 0) return index;
                    bricks += priorityQueue.Dequeue();
                    ladders--;
                }
            }

            return heights.Length - 1;
        }
    }
}