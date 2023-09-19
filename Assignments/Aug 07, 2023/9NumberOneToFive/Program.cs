namespace NumberOneToFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number between 1 and 10 (Enter 0 to stop):");
            
              while(true)
              {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine()); 

                if (number >= 1 &&  number <= 5)
                {
                    Console.WriteLine($"Valid number: {number}");
                }
                else if (number == 0)
                {
                    break;// Exit the loop if the user enter 0
                }
                else
                { 
                    Console.WriteLine("Number not in the range 1 to 5.");
                }
              }

        }
    }
}