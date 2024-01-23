namespace MaximumLengthofaConcatenatedStringwithUniqueCharacters
{
    internal class Solution
    {
        private int res = 0;
        public int MaxLength(IList<string> arr)
        {
            if(arr.Count==0) return 0;

            dfs(arr, "", 0);
            return res;
        }
        private void dfs(IList<string> list, string val, int index)
        {
            bool checkUnique = CheckUnique(val);
            if (checkUnique)
                res = Math.Max(val.Length, res);

            if (index == list.Count || !checkUnique)
                return;

            for (int i = index; i < list.Count; i++)
                dfs(list, val + list[i], i + 1);



        }
        private bool CheckUnique(string txt)
        {
            HashSet<char> unique = new();
            foreach (char c in txt)
            {
                if (unique.Contains(c))
                    return false;
                else
                    unique.Add(c);
            }
            return true;
        }
    }
}