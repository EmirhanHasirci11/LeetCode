namespace ValidParentheses
{
    internal class Solution
    {       
        public  bool IsValid(string s)
        {
            Stack<char> stack = new();
            if (s.Length < 2)
                return false;
            if (s.StartsWith(')') || s.StartsWith(']') || s.StartsWith('}'))
                return false;
            foreach (char x in s)
            {

                if (x == '(' || x == '{' || x == '[')
                    stack.Push(x);
                else if (stack.Count != 0)
                {
                    if ((x == ']' && stack.Peek() == '[' || x == '}' && stack.Peek() == '{') || x == ')' && stack.Peek() == '(')
                        stack.Pop();
                    else
                        return false;
                }
                else
                    return false;

            }
            if (!stack.Any())
                return true;
            else
                return false;

        }
    }
}