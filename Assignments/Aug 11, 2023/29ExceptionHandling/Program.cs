namespace ExceptionHandling
{
    internal class Program
    {
        static void Main()
        {
            try
            {   Console.Write("Input a number: ");
                double number = Convert.ToDouble(Console.ReadLine());

                if (number >= 0)
                {  double squareRoot =Math.Sqrt(number);
                    Console.WriteLine("Square root:" + squareRoot);
                }
                else
                {
                 throw new ArgumentException("Number cannot be negative!");
                }
            }
            catch (FormatException)
            {
             Console.WriteLine("Error: Invalid input. Please input a valid number.");
            }
            catch (ArgumentException ex)
            {
             Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
             Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}