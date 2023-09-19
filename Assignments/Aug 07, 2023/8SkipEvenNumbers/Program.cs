namespace SkipEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers 1 to 10 skipping even numbers:");
            for (int i = 1;  i <= 10; i++ )
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " ");
                }

            }
        }
    }
}