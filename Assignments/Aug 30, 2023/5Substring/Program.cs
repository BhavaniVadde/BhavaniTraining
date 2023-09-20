using System;
using System.ComponentModel;

namespace SSubstring
{
    public class Program
    {
        static void Main()
        {
            string? str1, str2;
            bool m;
            Console.Write("Input the string : ");
            str1 = Console.ReadLine();

            Console.Write("Input the substring to  search : ");
            str2 = Console.ReadLine();

            if (!string.IsNullOrEmpty(str1) && !string.IsNullOrEmpty(str2))
            {
          // Contains method to check if 'str1' contains 'str2' and store the result in the boolean variable 'm'.
                 m = str1.Contains(str2);

                if (m) //Check the boolean value stored in 'm'(true if 'str1' contains 'str2', false otherwise).
                {
                    Console.Write("The substring exists in the string.\n\n");
                }
                else
                {
                    Console.Write("The substring is not exists in the string. \n\n");
                }
            }
        }
    }
}