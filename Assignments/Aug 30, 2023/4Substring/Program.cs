using System.Data.SqlTypes;
using static System.Formats.Asn1.AsnWriter;

namespace Substring
{
    public class Program
    {
        static void Main()
        {
            string? str;// Declare a nullable string variable named 'str'.
            char[] arr1; // Declare a character array variable named 'arr1'.
            int pos, l, ln, c = 0; // Declare integer variables 'pos', 'l', 'ln', and 'c' and initialize 'c' to 0.


            Console.Write("Input the string : ");
            str = Console.ReadLine();

            if (!string.IsNullOrEmpty(str))// Check if the 'str' variable is not null or empty.
            {
                ln = str.Length;// Get the length of the input string and store it in the 'ln' variable.
                arr1 = str.ToCharArray(0, ln);// Convert the input string 'str' to a character array 'arr1'.

                Console.Write("Input the position to start extraction :");
                pos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input the length of substring :");
                l = Convert.ToInt32(Console.ReadLine());

                Console.Write("The substring retrieve from the string is : ");
                while (c < l) //while loop that iterates for 'l' times(the length of the substring).
                {
                    // Print the character from 'arr1' at the position 'pos + c - 1'
                    Console.Write(arr1[pos + c - 1]);
                    c++;// Increment the 'c' variable to move to the next character in the substring.
                }
                Console.Write("\n\n");
            }
        }
    }
}