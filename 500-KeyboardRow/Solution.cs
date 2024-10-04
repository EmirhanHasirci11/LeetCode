namespace KeyboardRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" });
        }
        static public string[] FindWords(string[] words)
        {
            string fR = "qwertyuiop";
            string sR = "asdfghjkl";
            string lR = "zxcvbnm";
            List<string> result =new ();
            foreach (string word in words)
            {
                int c1 = 0, c2 = 0, c3 = 0;
                foreach (char c in word.ToLower())
                {
                    if (fR.Contains(c))
                        c1++;
                    if (sR.Contains(c))
                        c2++;
                    if (lR.Contains(c))
                        c3++;
                    if(c1==word.Length||c2==word.Length||c3==word.Length)
                        result.Add(word);
                }
            }
            return result.ToArray();
        }
    }
}
