namespace ExceptionHandling
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int a, b;
                Console.Write("Enter first number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number");
                b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("Result of division" + c);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}