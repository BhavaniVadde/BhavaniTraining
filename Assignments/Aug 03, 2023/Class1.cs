using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithematicOperation
{
    internal class Class1
    {
        public static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;

            if (num2 != 0)
            {
                double division = num1 / num2;
                double modulus = num1 % num2;

                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Difference: " + difference);
                Console.WriteLine("Product: " + product);
                Console.WriteLine("Division: " + division);
                Console.WriteLine("Modulus: " + modulus);
            }
            else
            {
                Console.WriteLine("Cannot perform division and modulus as the second number is zero.");
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Difference: " + difference);
                Console.WriteLine("Product: " + product);
            }
        }
    }
}
