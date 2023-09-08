namespace CheckNegativePositive
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first Integer : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Second Integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is Negative and one is Positive");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
        }
    }
}