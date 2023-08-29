namespace SumofnNaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("The first " + n + " natural numbers are:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
           Console.WriteLine("The Sum of Natural Numbers up to " + n + " terms: " + sum);
        }
    }
}