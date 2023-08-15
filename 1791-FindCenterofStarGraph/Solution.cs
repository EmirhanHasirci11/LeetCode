namespace FindCenterofStarGraph
{
    internal class Solution
    {
        public int FindCenter(int[][] edges)
        {
            int[] nodes = new[] { edges[0][0], edges[0][1], edges[1][0], edges[1][1] };

            for (int i = 0; i < nodes.Length; i++)
            {
                for (int j = 0; j < nodes.Length; j++)
                {
                    if (i != j && nodes[i] == nodes[j])
                        return nodes[i];

                }
            }

            return 0;
        }
    }
}