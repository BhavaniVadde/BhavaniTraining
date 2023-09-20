namespace ExceptionHandling
{
    public class Program
    {
        static void Main()
        {
            // Start a try-catch block to handle potential exceptions.
            try
            {
                // Declare two integer variables 'a' and 'b'.
                int a, b;
                Console.Write("Enter first number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                b = Convert.ToInt32(Console.ReadLine());
                // Perform integer division of 'a' by 'b' and store the result in 'c'.
                int c = a / b;
                // Print the result of the division
                Console.WriteLine("Result of division: " + c);
            }
            // Catch any exceptions that might occur during execution.
            catch (Exception ex)
            {
                // If an exception is caught, print its error message to the console.
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}