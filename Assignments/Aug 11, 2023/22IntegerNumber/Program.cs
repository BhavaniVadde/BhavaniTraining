namespace IntegerNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an Integer:");
            int X = Convert.ToInt32(Console.ReadLine());
            //calls the result method with input X and prints the result.
            Console.WriteLine(result(X));
        }
  // Defined 'result' method that takes an integer parameter 'n' and returns a boolean value.
        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
               return true;
               return false;
        }
    }
}