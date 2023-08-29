namespace VoteEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Your are eligible to vote:");
            }
            else
            {
                Console.WriteLine("Your are not eligible to vote:");
            }
             Console.ReadKey();
        }
    }
}