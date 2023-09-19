namespace LargestofThree
{
    internal class Program
    {
         private static void Main(string[] arg)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest;

            if (num1 >= num2 && num1 >= num3) 
            {
                largest = num1;
            }
            else if (num2 >= num3)
            {
                largest = num2;
            }
            else
            {
                largest = num3;
            }
            Console.WriteLine($"The largest number is: {largest}");
        }
    }
}