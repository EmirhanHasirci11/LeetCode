namespace DetectCapital
{
    internal class Solution
    {        
        public bool DetectCapitalUse(string word)
        {
            int countOfCapital = 0;
            for(int i=0;i<word.Length;i++)            
                if (char.IsUpper(word[i]))
                    countOfCapital++;
            
            return countOfCapital == word.Length ? true : countOfCapital == 1 && char.IsUpper(word[0])?true:countOfCapital==0?true:false;
        }
    }
}