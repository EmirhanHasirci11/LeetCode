namespace CheckifWordEqualsSummationofTwoWords
{
    internal class Solution
    {
        
        public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            int first=convertInt(firstWord);
            int second=convertInt(secondWord);
            int third=convertInt(targetWord);
            return first+second==third?true:false;
        }
        private int convertInt(string word)
        {
            int res = 0;
            for(int i=0;i<word.Length;i++)            
                res = res * 10 + (word[i] - 'a');
            
            return res;
        }
    }
}