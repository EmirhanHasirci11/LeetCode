namespace FindAllPeopleWithSecret
{
    internal class Solution
    {        
        public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
        {
            Dictionary<int, List<(int, int)>> graph = new Dictionary<int, List<(int, int)>>();
            for (int i = 0; i < n; i++)
                graph[i] = new List<(int, int)>();

            foreach (int[] meet in meetings)
            {
                graph[meet[0]].Add((meet[1], meet[2]));
                graph[meet[1]].Add((meet[0], meet[2]));
            }

            List<int> ans = new List<int>();
            PriorityQueue<(int, int), int> que = new PriorityQueue<(int, int), int>();
            bool[] visited = new bool[n];
            que.Enqueue((0, firstPerson), 0);
            que.Enqueue((0, 0), 0);
            while (que.Count > 0)
            {
                var cur = que.Dequeue();
                if (visited[cur.Item2])
                    continue;
                visited[cur.Item2] = true;
                ans.Add(cur.Item2);
                int time = cur.Item1;
                foreach (var neigh in graph[cur.Item2])
                {
                    if (!visited[neigh.Item1] && time <= neigh.Item2)
                        que.Enqueue((neigh.Item2, neigh.Item1), neigh.Item2);
                }
            }
            return ans;
        }
    }
    }
}