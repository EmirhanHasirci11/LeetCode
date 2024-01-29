namespace ImplementQueueusingStacks
{
    public class MyQueue
    {
        Stack<int> input;
        Stack<int> output;
        public MyQueue()
        {
            input = new();
            output=new();
        }

        public void Push(int x)
        {
            input.Push(x);
        }

        public int Pop()
        {
            int current=Peek();
            output.Pop();
            return current;
        }

        public int Peek()
        {
            if(output.Count==0)
                while(input.Count!=0)
                    output.Push(input.Pop());
            return output.Peek();
        }

        public bool Empty()
        {
            return input.Count==0&&output.Count==0;
        }
    }

}