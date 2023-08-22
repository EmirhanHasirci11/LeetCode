using System.Text;

namespace ExcelSheetColumnTitle
{
    internal class Solution
    {        
        public string ConvertToTitle(int columnNumber)
        {
            StringBuilder sb = new();
            while (columnNumber > 0)
            {
                int remainder = (columnNumber - 1)%26;
                char c = (char)('A' + remainder);
                sb.Insert(0, c);
                columnNumber=(columnNumber-1)/26;
            }
            return sb.ToString();
        }
    }
}