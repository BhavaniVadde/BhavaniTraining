namespace ArithematicOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithematic Operations menu:");
            Console.WriteLine("1. Addition:");
            Console.WriteLine("2. Substraction:");
            Console.WriteLine("3. Multiplication:");
            Console.WriteLine("4. Division:");

            Console.Write("Enter your choice (1/2/3/4): ");
            char choice =char.Parse(Console.ReadLine());

            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case'1':
                    result = num1 + num2;
                    Console.WriteLine($"Result of addition:{result}");
                    break;

                case'2':
                    result = num1 - num2;
                    Console.WriteLine($"Result of substraction:{result}");
                    break;

                case'3':
                    result = num1 * num2;
                    Console.WriteLine($"Result of multiplication:{result}");
                    break;

                case '4':
                    if ( num2 != 0 )
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result of division:{result}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}