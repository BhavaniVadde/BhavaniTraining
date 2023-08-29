namespace IntegerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an Integer:");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(X));
        }
        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true; return false;
        }
    }
}