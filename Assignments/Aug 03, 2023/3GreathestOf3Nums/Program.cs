namespace GreathestOf3Nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.Write("Enter number 1 :");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 3 :");
            num3 = Convert.ToInt32(Console.ReadLine());

            int biggestNum = num1 > num2 && num1 > num3 ? num1 : num2 > num3 ? num2 : num3;
            Console.WriteLine($"Biggest of 3 numbers is: {biggestNum}");
        }
    }
}