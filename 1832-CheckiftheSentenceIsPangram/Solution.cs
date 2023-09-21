namespace CheckiftheSentenceIsPangram
{
    internal class Solution
    {        
        public bool CheckIfPangram(string sentence)
        {
            HashSet<char> hs = new(sentence);
            for(int i = 'a'; i <= 'z'; i++)
            {
                if(!hs.Contains((char)i))
                    return false;
            }
            return true;
        }
    }
}