namespace ExceptionHandling
{
    public class Program
    {
        static void Main(string[] args)
        {   
            // Declared 2 integer variables num1 and num2
            int number1, number2;
            // Starts a try-catch block to handle exception potential
            try
            {
                Console.Write("Enter first number: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                number2 = Convert.ToInt32(Console.ReadLine());
                int result = number1 / number2;
                Console.WriteLine($"result: {result}");
            }
            catch (DivideByZeroException)
            {
              // Catch a 'DivideByZeroException' if attempts to divide by zero.
                Console.WriteLine("Second number should not be zero");
            }
            catch (FormatException)
            {   
             // Catch a 'FormatException' if the input that cannot be converted to an integer.
                Console.WriteLine("Enter only the integer number");
            }
        }
        
    }
}