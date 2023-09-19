namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            try
            {
                Console.Write("Enter first number");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number");
                number2 = Convert.ToInt32(Console.ReadLine());
                int result = number1 / number2;
                Console.WriteLine($"result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Second number should not be zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only the integer number");
            }
        }
        
    }
}