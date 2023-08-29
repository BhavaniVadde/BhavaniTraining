namespace FactorialCalculator
{
    internal class Program
    {
        static int CalculatorFactorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return num * CalculatorFactorial(num - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                int factorial = CalculatorFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {factorial}");
            }
        }
    }
}