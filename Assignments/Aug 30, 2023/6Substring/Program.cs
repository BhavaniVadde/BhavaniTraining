using System;

namespace Substring
{
    public class Program
    {
        static void Main()
        {
            string? str1;
            string? findstr;


            Console.Write("Input a String: ");
            str1 = Console.ReadLine();

            Console.Write("Input a substring to be found in the string: ");
            findstr = Console.ReadLine();

            if (!string.IsNullOrEmpty(str1) && !string.IsNullOrEmpty(findstr))
            {
//find the first occurrence of 'findstr' in 'str1' and store the result in the 'index' variable.
                int index = str1.IndexOf(findstr);
     // Check if the 'index' is less than 0, which means 'findstr' was not found in 'str1'.
                if (index < 0)
                {
                    Console.WriteLine("The substring no found  in the given string \n");
                }
                else
                {
                    // Display a message indicating the position where 'findstr' was found in 'str1'.
                    Console.WriteLine("Found '{0}' in '{1}' at position {2}", findstr, str1, index);
                }

            }
        }
    }
}

