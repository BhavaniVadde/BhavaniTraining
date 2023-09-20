using System.Threading;

namespace SumofnNaturalNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //prompts to enter input number and displays text
            Console.Write("Enter a number: ");
            //Reads the input entered and converts to an integer, and stores in variable n
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            //displays first n natural numbers
            Console.Write("The first " + n + " natural numbers are:");
            // Use a for loop to iterate over natural numbers from 1 to n
            for (int i = 1; i <= n; i++)
            {
                // Display the current natural number followed by a space
                Console.Write(i + " ");
                // Display the current natural number followed by a space
                sum += i;
            }
            //sum of the natural numbers calculated, along with the value of n and displays final result
           Console.WriteLine("\nThe Sum of Natural Numbers up to " + n + " terms: " + sum);
        }
    }
}