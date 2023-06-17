namespace AddBinary
{
    internal class Solution
    {        
        public string AddBinary(string a, string b)
        {
            int carry = 0;
            string result = "";
            if (a.Length < b.Length)
                a = a.PadLeft(b.Length, '0');
            else
                b = b.PadLeft(a.Length, '0');
            for(int i = a.Length - 1; i >= 0; i--)
            {
                var tempA = char.GetNumericValue(a[i]);
                var tempB = char.GetNumericValue(b[i]);
                result = ((carry+ tempA + tempB)%2)+result;
                carry = (carry + tempA + tempB) >= 2 ? 1 : 0;                    
            }
            return carry != 0 ? carry+result:result ;

        }

    }
}