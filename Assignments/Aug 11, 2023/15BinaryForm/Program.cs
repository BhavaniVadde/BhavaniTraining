namespace BinaryForm
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //displays message and prompts to enter input
            Console.Write("Enter the Decimal Number:");

            //reads the input and converts to an integer variable and stores the value in number
            int number = Convert.ToInt32(Console.ReadLine());
            int i;
            
          //declare int array numberarray is used as counter loop and stores the binary digits of the converted num
            int[] numberArray = new int[number];
            //calculates the remainder, either 0 or 1 stores numberarray i and loop
            for (i = 0; number > 0; i++)
            { 
                numberArray[i] = number % 2;
                number = number / 2;
            }
            //displays the message
            Console.Write("Binary of the given Number:");
            //for loop checks the in reverse order and prints numberarray
            for(i = i-1; i >= 0; i--) 
            {
                Console.Write(numberArray[i]);
            }
            //waits to press anykey before it exists 
            Console.ReadKey();
        }
    }
}