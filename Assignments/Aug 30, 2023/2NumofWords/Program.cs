using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace NumofWords
{
    public class Program
    {
        static void Main()
        {   
            //declare a nullable string str and integer variables wrd and l
            string? str;
            int wrd;
            int l;
            //displays message asks to input string and reads input string and stors in str variable
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            //initialize integer varibles l=0, wrd=1 it meant to count the 1st wrd 
            l = 0;
            wrd = 1;
            //check if the str varible is not null or emmpty
            if (!string.IsNullOrEmpty(str))
            {
                //while loop iterates through the characters in the input string
                while (l <= str.Length - 1)
                {    
                    //checks if the current is a characters space, newline and tab
                    if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                    {
                        wrd++;/*Increment the wrd variable to count the wrd*/ 
                    }

                    l++;/*increment L varible to move to the character in the input string*/
                }
            }
                //displays the total no.of wrds counted in the input string
                Console.Write("Total number of words in the string is : {0}\n", wrd);
            
        }
    }
}