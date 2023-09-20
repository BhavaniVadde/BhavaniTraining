namespace SwapNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
          // Assign the value of 'number1' to the 'temp' variable to temporarily store it.
            temp = number1;
 // Assign the value of 'number2' to 'number1' to swap the values of 'number1' and 'number2'.
            number1 = number2;
            // Assign the value of 'temp' to 'number2'.
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            // Display the value of 'number1' after swapping.
            Console.Write("\nFirst Number : " + number1);
            // Display the value of 'number2' after swapping.
            Console.Write("\nSecond Number : " + number2);
            Console.Read();
        }
    }
}