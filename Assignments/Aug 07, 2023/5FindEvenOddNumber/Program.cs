namespace FindEvenOddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers between 1 and 10:");
            for (int i = 2; i <= 10; i += 2) 
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("/nodd numbers between 1 and 10:");
            for (int i = 1; i <= 10; i += 2) 
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}