using System.Text;

namespace CheckIfTwoStringArraysareEquivalent
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            StringBuilder sb1= new ();
            StringBuilder sb2= new ();
            word1.ToList().ForEach(c=>sb1.Append(c));
            word2.ToList().ForEach(c=>sb2.Append(c));
            return sb1.ToString().Equals(sb2.ToString());
        }
    }
}