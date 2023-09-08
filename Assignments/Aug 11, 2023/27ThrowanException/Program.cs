namespace ThrowanException
{
    public class Program
    {
        static void Main()
        {
            int number;
            // Start a try-catch block to handle potential exceptions.
            try
            { Console.Write("Input numeric integer");
              number = Convert.ToInt32(Console.ReadLine());
                // If 'number' is not within the valid range (0 to 1000)
                if (number < 0 || number > 1000)
                {
                    // with a custom error message indicating the valid range.
                    throw new ArgumentOutOfRangeException("Number must be between 0 and 1000.");
                }

                Console.WriteLine("Input is valid.");
            }
            catch (FormatException)
            {
// Catch a 'FormatException' if the user enters input that cannot be converted to an integer.
                Console.WriteLine("Invalid input. Please enter a valid numeric integer.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
             // Catch an 'ArgumentOutOfRangeException' and print the exception's error message.
                Console.WriteLine(ex.Message);
            }
        }
    }
}