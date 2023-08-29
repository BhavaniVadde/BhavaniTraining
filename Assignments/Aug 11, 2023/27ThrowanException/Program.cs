namespace ThrowanException
{
    internal class Program
    {
        static void Main()
        {
            int number;
            try
            { Console.Write("Input numeric integer");
              number = Convert.ToInt32(Console.ReadLine());

                if (number < 0 || number > 1000)
                {
                    throw new ArgumentOutOfRangeException("Number must be between 0 and 1000.");
                }

                Console.WriteLine("Input is valid.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric integer.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}