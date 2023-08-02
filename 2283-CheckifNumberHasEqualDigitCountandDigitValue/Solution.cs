using System.Text;

namespace CheckifNumberHasEqualDigitCountandDigitValue
{
    internal class Solution
    {
        public  bool DigitCount(string num)
        {
            Dictionary<double, int> map = new();
            foreach (char i in num)
            {
                var val = Char.GetNumericValue(i);
                if (map.ContainsKey(val))
                    map[val]++;
                else
                    map[val] = 1;
            }
            StringBuilder sb = new ();
            for(int i=0;i<num.Length;i++)
            {
               if(map.ContainsKey(i))
                    sb.Append(map[i]);
               else
                    sb.Append('0');
            }
            return sb.ToString()==num;
        }
    }
}