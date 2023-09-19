namespace _1Arrays
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of values (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            // creating an integer array 'arr' with size 'n'
            int[] arr = new int[n];

            // Read values into the array
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elements - {i + 0}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nValues in reverse order:");

            // Display values in reverse order
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.Write('\n');
        }
    }
}