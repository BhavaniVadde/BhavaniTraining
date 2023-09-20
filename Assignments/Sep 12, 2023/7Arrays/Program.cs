namespace _7Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a stack with unsorted elements
            Stack<int> inputStack = new Stack<int>();
            inputStack.Push(5);
            inputStack.Push(2);
            inputStack.Push(9);
            inputStack.Push(1);
            inputStack.Push(8);

            Console.WriteLine("Original Stack:");
            PrintStack(inputStack);

            // Sort the stack
            Stack<int> sortedStack = SortStack(inputStack);

            Console.WriteLine("\nSorted Stack (Ascending Order):");
            PrintStack(sortedStack);
        }

        // SortStack function to sort the input stack
        static Stack<int> SortStack(Stack<int> inputStack)
        {
            Stack<int> sortedStack = new Stack<int>();

            // Iterate through the input stack
            while (inputStack.Count > 0)
            {
                int temp = inputStack.Pop();

                // Compare elements and push them back into inputStack or sortedStack
                while (sortedStack.Count > 0 && sortedStack.Peek() > temp)
                {
                    inputStack.Push(sortedStack.Pop());
                }

                sortedStack.Push(temp);
            }

            return sortedStack;
        }

        // PrintStack function to print the contents of a stack
        static void PrintStack(Stack<int> stack)
        {
            foreach (int item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}