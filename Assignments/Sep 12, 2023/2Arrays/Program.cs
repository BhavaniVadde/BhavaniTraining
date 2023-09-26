using System.Diagnostics.CodeAnalysis;

namespace _2Arrays
{
    public class Program
    {
        static void Main()
        {
            int sum = 0;
            Console.Write("Enter the number of values(n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            // Create an integer array 'arr' of size 'n'
            int[] arr = new int[n];
            // Read values into the array
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter value {i + 0} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                // Iterate through the array and add each element to the sum
                sum += arr[i];
            }
            Console.Write($"\nSum of all the elements in an array is:{sum}\n\n ");
        }
    }
}
   
