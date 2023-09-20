using System.Runtime.CompilerServices;

namespace AsteriskPyramid
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //declares an integer varible n and initialized its value 3
            int n = 3; 
        //declares variable i and its initializes i to 1, continues i lessthan or equal to n.controls no.of rows in pattern
            for (int i = 1; i <= n; i++)
            {   
                //inner loop printing spaces before the asterisks and it dependents value n and i
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                //inner loop printing no.of asterisks(*) and it depends value i
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                //to move next line and for creating new line next row in pyramid 
                Console.WriteLine();
            }
        }    
    }
}