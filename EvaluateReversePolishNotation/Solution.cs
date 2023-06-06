namespace EvaluateReversePolishNotation
{
    public class Solution
    {
        private static readonly Dictionary<string, Func<int, int, int>> s_Funcs = new() {
      { "+", (right, left) => left + right},
      { "-", (right, left) => left - right },
      { "*", (right, left) => left * right },
      { "/", (right, left) => left / right },
    };

        public int EvalRPN(string[] tokens)
        {
            Stack<int> data = new();
            foreach (string token in tokens)
                if (int.TryParse(token, out int value))
                    data.Push(value);
                else
                    data.Push(s_Funcs[token](data.Pop(), data.Pop()));
            return data.Pop();
        }
    }
}