using System;

namespace InsertSubstring
{
    public class Program
    {
        static void Main()
        {
            string? str1;// Declare a nullable string variable 'str1'.
            string? findstring;// Declare a nullable string variable 'findstring'.
            string? insertstring;// Declare a nullable string variable 'insertstring'.
            int i;

            Console.Write("Input the original string : ");
            str1 = Console.ReadLine();
            Console.Write("Input the string to be searched for : ");
            findstring = Console.ReadLine();
            Console.Write("Input the string to be inserted : ");
            insertstring = Console.ReadLine();

            // Checks if 'str1','findstring' and inserstring are not null or empty.
            if (!string.IsNullOrEmpty(str1) && !string.IsNullOrEmpty(findstring) && (!string.IsNullOrEmpty(insertstring)))
            {
                // The first occurrence of 'findstring' in 'str1' and store it in the 'i' variable.
                i = str1.IndexOf(findstring);
                // Trim any leading whitespace from 'insertstring' and add spaces around it.
                insertstring = " " + insertstring.Trim() + " ";
                // Insert 'insertstring' into 'str1' at the position determined by 'i'.
                str1 = str1.Insert(i, insertstring);
                // Display the modified string.
                Console.Write("The modified string is : {0}\n\n", str1);
                
            }
        }
    }
}