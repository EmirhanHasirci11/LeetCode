using System.Text;

namespace GenerateaStringWithCharactersThatHaveOddCounts
{
    internal class Solution
    {        
        public string GenerateTheString(int n)
        {           
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
                sb.Append('a');
            return n%2!=0? sb.ToString() : sb.ToString().Substring(0,n-1)+'b';
            
                

        }

    }
}