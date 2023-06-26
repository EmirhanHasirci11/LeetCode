namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public IList<string> FizzBuzz(int n)
        {
            List<string> list = new();
            for(int i = 1; i <= n; i++)
            {
                if (n % 15 == 0)
                    list.Add("FizzBuzz");
                else
                    list.Add(i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString());
            }
            
            return list;
        }
    }
}