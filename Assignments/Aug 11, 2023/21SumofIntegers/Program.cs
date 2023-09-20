namespace SumofIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
         // SumTriple method with different sets of arguments and print the results.
            Console.WriteLine(SumTriple(6, 6));
            Console.WriteLine(SumTriple(8, 15));
            Console.WriteLine(SumTriple(-7, 5));
        }
 // Define the SumTriple method that takes two integer parameters a&b and returns an integer.
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
    }
}