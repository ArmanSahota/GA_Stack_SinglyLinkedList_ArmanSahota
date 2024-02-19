namespace GA_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();

            // Push elements
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Pop an element
            Console.WriteLine($"Popped: {stack.Pop()}");

            // Peek at the top element
            Console.WriteLine($"Top element: {stack.Peek()}");

            // Display count
            Console.WriteLine($"Count: {stack.Count}");

            Console.ReadLine();
        }
    }
}



