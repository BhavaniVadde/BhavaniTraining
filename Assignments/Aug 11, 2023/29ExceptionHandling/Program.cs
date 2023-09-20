namespace ExceptionHandling
{
    public class Program
    {
        static void Main()
        {   
            // Starts a try-catch block to handle potential exceptions.
            try
            {   Console.Write("Input a number: ");
                double number = Convert.ToDouble(Console.ReadLine());

                if (number >= 0)
                {   
                    // Calculates squareroort of the number and stores in squareRoot.
                    double squareRoot =Math.Sqrt(number);
                    Console.WriteLine("Square root:" + squareRoot);
                }
                else
                {
                   // If 'number' is negative, throws an 'ArgumentException' message.
                    throw new ArgumentException("Number cannot be negative!");
                }
            }
            catch (FormatException)
            {
                // Catch a 'FormatException' if input that cannot be converted to a double.
                Console.WriteLine("Error: Invalid input. Please input a valid number.");
            }
            catch (ArgumentException ex)
            { 
              // Catch a 'ArgumentException' and prints exception error message.
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
              // Catch any other exception and prints a error message.
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}