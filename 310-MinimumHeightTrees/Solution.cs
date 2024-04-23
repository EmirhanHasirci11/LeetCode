namespace MinimumHeightTrees
{
    internal class Solution
    {       
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {            
            if (n == 1)            
                return new List<int> { 0 };
                        
            var adjList = new List<int>[n];
            for (int i = 0; i < n; i++)            
                adjList[i] = new List<int>();
                        
            foreach (var edge in edges)
            {
                int u = edge[0];
                int v = edge[1];
                adjList[u].Add(v);
                adjList[v].Add(u);
            }
            
            var leaves = new List<int>();
            for (int i = 0; i < n; i++)            
                if (adjList[i].Count == 1)
                
                    leaves.Add(i);
                
            
            
            int remainingNodes = n;
            
            while (remainingNodes > 2)
            {                
                remainingNodes -= leaves.Count;
                
                var newLeaves = new List<int>();
                
                foreach (var leaf in leaves)
                {
                    int neighbor = adjList[leaf][0];
                    adjList[neighbor].Remove(leaf);
                    
                    if (adjList[neighbor].Count == 1)                    
                        newLeaves.Add(neighbor);                    
                }
                
                leaves = newLeaves;
            }            
            return leaves;
        }
    }
}
