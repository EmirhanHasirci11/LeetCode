namespace FindifPathExistsinGraph
{
    internal class Solution
    {
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            var adj = BuildAdjacencyList(edges);
            return DFS(adj, source, destination);
        }
        public bool DFS(Dictionary<int, List<int>> adj, int source, int destination)
        {
            return DepthFirstSearch(adj, new HashSet<int>(), source, destination);
        }

        public bool DepthFirstSearch(Dictionary<int, List<int>> adj, HashSet<int> visited, int u, int destination)
        {
            if (u == destination)
            {
                return true;
            }

            if (!visited.Contains(u))
            {
                visited.Add(u);
                foreach (var v in adj[u])
                {
                    if (DepthFirstSearch(adj, visited, v, destination))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public Dictionary<int, List<int>> BuildAdjacencyList(int[][] edges)
        {
            var adj = new Dictionary<int, List<int>>();
            foreach (var edge in edges)
            {
                var u = edge[0];
                var v = edge[1];
                if (!adj.ContainsKey(u))
                {
                    adj[u] = new List<int>();
                }

                if (!adj.ContainsKey(v))
                {
                    adj[v] = new List<int>();
                }

                adj[u].Add(v);
                adj[v].Add(u);
            }

            return adj;
        }
    }
}
