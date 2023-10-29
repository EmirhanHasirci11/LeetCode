namespace LongestCommonPrefix
{
    internal class Program
    {        
        public string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs);
            string first = strs[0];
            string last = strs[strs.Length-1];
            int index = 0;
            while(index<first.Length && index<last.Length) 
            {
                if (first[index] == last[index])
                    index++;
                else
                    break;
            }
            return first.Substring(0, index);
        }
    }
}