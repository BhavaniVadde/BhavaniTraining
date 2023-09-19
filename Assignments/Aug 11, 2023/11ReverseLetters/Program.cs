namespace ReverseLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter letter: ");
            char letter1 = NewMethod();
            Console.Write("Enter letter: ");
            char letter2 = NewMethod1();
            Console.Write("Enter letter: ");
            char letter3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Reversed order: " + letter3 + " " + letter2 + " " + letter1);
        }

        private static char NewMethod1()
        {
            return Convert.ToChar(Console.ReadLine());
        }

        private static char NewMethod()
        {
            return Convert.ToChar(Console.ReadLine());
        }
    }
}