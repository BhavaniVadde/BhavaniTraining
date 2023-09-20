namespace EvenorOdd
{
  public class Program
    {
        static void Main(string[] args)
        {   
            //declared integer variables n1 and n2, and stores 2 input numbers
            int n1, n2;
   //declared a boolean variable botheven and checks the condition both input nums are even
            bool bothEven;
            //displays the message and prompts to enter input num
            Console.Write("Input First number: ");
            //reads the input and converts to an integer variable, stores in n1 varible.
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            bothEven = ((n1 % 2 == 0) && (n2 % 2 == 0)) ?  true: false;
            //displays the message 
            Console.WriteLine(bothEven ? "there're numbers bothEven" : "there's a number odd");

        }
    }
}