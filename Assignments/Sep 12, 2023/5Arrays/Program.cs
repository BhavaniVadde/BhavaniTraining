using System.Linq.Expressions;

namespace _5Arrays
{
    public class Program
    {
        static void Main()
        {
            Console.Write($"Enter the number of values(n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elements - {i + 0}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Sort the array in ascending order
            Array.Sort(arr);
            // Reverse the sorted array to get it in descending order
            Array.Reverse(arr);
            Console.Write("\nElements of the array in sorted desecending order:");
            // Print the sorted array in descending order
            foreach (int elements in arr)
            {
                Console.Write(elements + " ");
            }
            Console.Write("\n\n");
            
        }
    }
}
            

        
    
