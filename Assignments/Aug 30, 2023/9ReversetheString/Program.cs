using System;
using System.Reflection;

namespace ReversetheString
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Input a String: ");
            string? input = Console.ReadLine();
            // Check if the 'input' variable is not null
            if (input != null)
            {
                // Convert the input string 'input' into a character array and store it in 'charArray'.
                char[] charArray = input.ToCharArray();
                // Get the length of the character array and store it in 'length'.
                int length = charArray.Length;
                int left = 0;
                int right = length - 1; //which represents the last character index.

                //while loop that continues as long as 'left' is less than 'right'.
                while (left < right)
                {
                    
                    char temp = charArray[left];//swap the charcters and store the left character in temp
                    charArray[left] = charArray[right];//copy the character at 'right' to 'left'
                    charArray[right] = temp; //copy the temp charcter from 'right' 


                    left++; //Increment 'left' to move to the next character from the left.
                    right--;//Decrement 'right' to move to the next charcter from the right.
                }
               //Create a new string from the reversed character array 'charArray'.
                string reversedString = new string(charArray);

                Console.WriteLine("Reversed string: " + reversedString);
            }
        }
    }
}