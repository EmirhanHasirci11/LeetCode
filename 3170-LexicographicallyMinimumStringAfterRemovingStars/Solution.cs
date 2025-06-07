using System.Text;

namespace LexicographicallyMinimumStringAfterRemovingStars
{
    internal class Solution
    {
        public string ClearStars(string s)
        {
            int n = s.Length;
            var pq = new PriorityQueue<char, char>(); // Min-heap
            var map = new Dictionary<char, List<int>>();
            var keep = new bool[n]; // Hangi karakterler tutulacak
            Array.Fill(keep, true);

            for (int i = 0; i < n; i++)
            {
                if (s[i] == '*')
                {
                    if (pq.Count > 0)
                    {
                        char temp = pq.Dequeue(); // En küçük karakter
                        int lastIndex = map[temp][map[temp].Count - 1]; // Son görülen index
                        map[temp].RemoveAt(map[temp].Count - 1);
                        keep[i] = false;         // '*' silinir
                        keep[lastIndex] = false; // eşleşen karakter silinir
                    }
                }
                else
                {
                    pq.Enqueue(s[i], s[i]); // Karakteri min-heap'e ekle
                    if (!map.ContainsKey(s[i]))
                        map[s[i]] = new List<int>();
                    map[s[i]].Add(i);
                }
            }

            // Sonuç string oluştur
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                if (keep[i])
                {
                    result.Append(s[i]);
                }
            }

            return result.ToString();
        }
    }
}
