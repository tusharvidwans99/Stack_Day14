namespace Stack_day14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Peek();
            stack.Pop();
            stack.Peek();

        }
    }
}