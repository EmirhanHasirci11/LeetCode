namespace RansomNote
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            var ransomNote = "aa";var magazine = "baa";
            Console.WriteLine(CanConstruct(ransomNote,magazine));
        }
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            if(ransomNote== null)return false;
            if (magazine == null) return false;
            Dictionary<char,int> mgzn= new Dictionary<char,int>();
            for(int i=0; i<magazine.Length;i++) 
            {
                if (mgzn.ContainsKey(magazine[i]))                
                    mgzn[magazine[i]]++;
                else               
                    mgzn.Add(magazine[i], 1);                
            }
            foreach(char c in ransomNote)
            {
                if (mgzn.ContainsKey(c))
                {

                    if (mgzn[c] <= 0)
                        return false;
                    mgzn[c]--;
                }
                else return false;
                
            }
            return true;

        }
    }
}