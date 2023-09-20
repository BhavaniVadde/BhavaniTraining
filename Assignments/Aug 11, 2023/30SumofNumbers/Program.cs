using System.Transactions;

namespace SumofNumbers
{
    public class Program
    {
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
             int digit = number % 10;
             sum += digit;
             number /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int sum = SumOfDigits(userInput);
            Console.WriteLine($"Sum of digits in {userInput} is {sum}");
        }
    }
}
