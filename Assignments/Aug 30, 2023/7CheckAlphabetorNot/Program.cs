namespace CheckAlphabetorNot
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Enter a character: ");
            // Read a single character from the input and store it in the 'inputChar' variable.
            char inputChar = Console.ReadKey().KeyChar;

            // Check if the input character is a letter (alphabetical character).
            if (char.IsLetter(inputChar))
            {
                // Check if the input character is an uppercase letter.
                if (char.IsUpper(inputChar))
                {
                    Console.WriteLine("\nIt's an uppercase letter.");
                }
                // Check if the input character is a lowercase letter.
                else if (char.IsLower(inputChar))
                {
                    Console.WriteLine("\nIt's a lowercase letter.");
                }
            }
            else
            {
                Console.WriteLine("\nIt's not an alphabet.");
            }
        }
    }
}