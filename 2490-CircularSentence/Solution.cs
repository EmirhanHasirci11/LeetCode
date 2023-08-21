namespace CircularSentence
{
    internal class Solution
    {        
        public bool IsCircularSentence(string sentence)
        {
            string[] words =sentence.Split(' ');
            if (words.Length == 1 && words[0][0] == words[words.Length-1][words[words.Length - 1].Length - 1])
                return true;
            
            if (words[0][0] != words[words.Length - 1][words[words.Length-1].Length - 1])
                return false;

            bool control=true;

            for(int i=0;i<words.Length-1;i++) 
            {
                char lastDigit = words[i][words[i].Length-1];
                if (lastDigit != words[i + 1][0])
                    return false;
            }

            return control;
        }
    }
}