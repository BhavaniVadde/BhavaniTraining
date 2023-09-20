using System.ComponentModel.DataAnnotations;

namespace CalculateStringLength
{
    public class Program
    {
        static int CalculateStringLength(string input)
        {
            //declare and initialize the integer variable length =0 and stores the length of the input string
            int length = 0;
            //foreach loop iterates each char ('c') in the input string
            foreach (char c in input)
            {
                length++; /*increaments length variable by 1 for each char in the input string*/
            }
            return length; /*returns calculated length of the string*/
        }

        public static void Main()
        {

            //Display message and asks to input the string,reads the inputstring and stores in inputString variable
            Console.Write("Enter a string: ");
            string? inputString = Console.ReadLine();
            //checks the inputstring is not null or empty
            if (!string.IsNullOrEmpty(inputString))
            {
                //calls the methods and stores the input string in the length variable
                int length = CalculateStringLength(inputString);
                Console.WriteLine($"The length of the string is: {length}");/*displays the message and calculated length*/
            }
        }
    }
}