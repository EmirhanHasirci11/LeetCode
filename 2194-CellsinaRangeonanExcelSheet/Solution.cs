namespace CellsinaRangeonanExcelSheet
{
    internal class Solution
    {        
        public IList<string> CellsInRange(string s)
        {
            List<string> list = new ();
            for(char i = s[0]; i <= s[3]; i++)            
                for(char j = s[1];j <= s[4];j++)
                    list.Add (""+i+j);
            return list;
            
        }
    }
}