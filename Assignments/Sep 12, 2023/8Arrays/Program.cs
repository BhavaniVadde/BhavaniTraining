namespace _8Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a stack with some elements
            Stack<int> myStack = new Stack<int>();
            myStack.Push(5);
            myStack.Push(7);
            myStack.Push(9);
            myStack.Push(11);
            myStack.Push(3);
            // Element to check
            int elementToCheck = 11;
            // Check if the element is present in the stack
            bool isPresent = IsElementPresent(myStack, elementToCheck);
            if (isPresent)
            {
                Console.WriteLine($"{elementToCheck} is present in the stack.");
            }
            else
            {
                Console.WriteLine($"{elementToCheck} is not present in the stack.");
            }
        }
        // Custom method to check if an element is present in the stack
        static bool IsElementPresent(Stack<int> stack, int element)
        {
            foreach (int item in stack)
            {
                if (item == element)
                {
                    return true; // Element found in the stack
                }
            }
            return false;// Element not found in the stack
        }
    }
}
            
             
            
        

    
