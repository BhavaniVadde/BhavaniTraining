﻿namespace AsteriskPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3; 
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }    
    }
}