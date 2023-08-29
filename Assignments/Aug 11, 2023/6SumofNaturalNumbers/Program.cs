namespace SumofNaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Sum of first 10 natural numbers");
            int n = 10;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i +" ");
                sum +=  i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}