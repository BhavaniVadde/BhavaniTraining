using System.ComponentModel.Design;

namespace VoteEligibility
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter your age:"); /*displays the text, prompting to input their age*/
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18) /*if-else statement checks weather the age is greater than or equal to 18*/
            {
                Console.WriteLine("Your are eligible to vote:");
            }
            else
            {
                Console.WriteLine("Your are not eligible to vote:");
            }
             Console.ReadKey(); /*waits user to press any key before program exists and allows to see the output*/
        }
    }
}