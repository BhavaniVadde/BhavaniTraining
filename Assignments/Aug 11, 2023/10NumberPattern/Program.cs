namespace NumberPattern
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int n = 4; 
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                { 
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}