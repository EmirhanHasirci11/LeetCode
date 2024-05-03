namespace CompareVersionNumbers
{
    internal class Solution
    {
        public int CompareVersion(string version1, string version2)
        {
            var v1 = version1.Split('.').Select(int.Parse).ToList();
            var v2 = version2.Split('.').Select(int.Parse).ToList();

            while (v1.Count > v2.Count) v2.Add(0);
            while (v2.Count > v1.Count) v1.Add(0);

            for (var i = 0; i < v1.Count; i++)
            {
                if (v1[i] < v2[i]) return -1;
                else if (v1[i] > v2[i]) return 1;
            }

            return 0;
        }
    }
}
