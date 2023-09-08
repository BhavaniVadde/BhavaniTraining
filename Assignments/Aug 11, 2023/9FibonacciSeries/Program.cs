using System.Runtime.CompilerServices;

namespace FibonacciSeries
{
    public class Program
    {
        static void Main(string[] args)
        {
           //declared variables and initializes values previous 2 terms,store current term,loop variable,and
            //no.of terms diplayed
            int prv = 0,pre = 1, trm,i, n;
            //displays introductory message
            Console.Write("\n\n");
            Console.Write("Display the first n terms of fibonacci series:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of terms to be display : ");
            n = Convert.ToInt32(Console.ReadLine());
           //displays no.of terms and initialize display with 1st two terms (prv and pre) of the series 
            Console.Write("Here is the fibonacci series upto  to {0} terms : \n", n);
            Console.Write("{0}    {1}", prv, pre);
            //this loop displays remaining terms in the series
            for (i = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write("  {0}  ", trm);
                prv = pre;
                pre = trm;
            }
            Console.Write("\n");
        }
    }
}