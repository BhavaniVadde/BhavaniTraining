namespace FindPrimeNumbers
{
    internal class Program
    {
        static void Main()
        {
            int i, j = 0, flag = 0;
            Console.Write("Enter the first number ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the  second number ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers between 1 to 10");

            j = n2 / 2;
            for (i = 0; i <= n2; i++)
            {
                if (n2 % i == 0)
                {
                    Console.Write("Number is not prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is prime.");
        }
    }
}





   

           
        
    
