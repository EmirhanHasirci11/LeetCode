namespace SumofDistancesinTree
{
    public class Solution
    {
        public int[] SumOfDistancesInTree(int n, int[][] edges)
        {
            // Step 1: Initialize adjacency list to represent the tree
            List<List<int>> graph = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                graph.Add(new List<int>());
            }

            // Step 2: Construct the adjacency list from edges
            foreach (var edge in edges)
            {
                int u = edge[0];
                int v = edge[1];
                graph[u].Add(v);
                graph[v].Add(u);
            }

            // Step 3: Calculate count and dist arrays using DFS
            int[] count = new int[n];
            int[] dist = new int[n];
            DFS1(0, -1, graph, count, dist); // Start DFS from node 0

            // Step 4: Update dist array using information from the first pass
            DFS2(0, -1, graph, count, dist, n);

            // Step 5: Return the updated dist array
            return dist;
        }

        // DFS function to calculate count and dist arrays
        private void DFS1(int node, int parent, List<List<int>> graph, int[] count, int[] dist)
        {
            count[node] = 1; // Initialize count of current node as 1
            foreach (int neighbor in graph[node])
            {
                if (neighbor != parent)
                { // Avoid visiting parent node
                    DFS1(neighbor, node, graph, count, dist); // Recursively visit neighbor
                    count[node] += count[neighbor]; // Update count of current node
                    dist[node] += dist[neighbor] + count[neighbor]; // Update dist of current node
                }
            }
        }

        // Second pass DFS function to update dist array
        private void DFS2(int node, int parent, List<List<int>> graph, int[] count, int[] dist, int n)
        {
            foreach (int neighbor in graph[node])
            {
                if (neighbor != parent)
                { // Avoid visiting parent node
                    dist[neighbor] = dist[node] - count[neighbor] + n - count[neighbor];
                    // Update dist of neighbor using information from parent node
                    DFS2(neighbor, node, graph, count, dist, n); // Recursively visit neighbor
                }
            }
        }
    }
}
