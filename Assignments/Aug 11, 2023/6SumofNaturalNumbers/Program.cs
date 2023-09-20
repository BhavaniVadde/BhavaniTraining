namespace SumofNaturalNumbers
{
    public class Program
    {
        static void Main()
        {
            // Display a message to indicate the purpose of the program
            Console.WriteLine("The Sum of first 10 natural numbers");
            //initialize variables to hold no.of natural numbers and their sum
            int n = 10;
            int sum = 0;
            // Use a for loop to iterate over natural numbers from 1 to n
            for(int i = 1; i <= n; i++)
            {
                // Display the current natural number followed by a space
                Console.Write(i +" ");
                // Display the current natural number followed by a space
                sum +=  i;
            }
            // Display the final sum of the natural numbers
            Console.WriteLine(sum);
            //waits to press any key before its exists
            Console.ReadLine();
        }
    }
}