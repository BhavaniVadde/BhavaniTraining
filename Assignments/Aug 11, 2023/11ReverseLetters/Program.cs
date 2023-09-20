using System.ComponentModel;

namespace ReverseLetters
{
    public class Program
    {
        static void Main()
        {
            // declared 3 character variables
            char letter, letter1, letter2;

            //display the message and prompts to input letter 
            Console.Write("Input letter: ");

            //Reads input letter, access the letter and it converts to char, and stores in letter variable
             letter = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.Write("Input letter: ");
             letter1 = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.Write("Input letter: ");
             letter2 = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();

            //using string format dispalys the input character and prints in reverse order
            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);


        }    
    }
}