namespace _4Arrays
{
    public class Program
    {
        static void Main()
        {
            Console.Write($"Enter the number of values(n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            // Creates an integer array of size n 
            int[] arr = new int[n];
            // Loop to input n elements into the array
            for (int i = 0; i < n; i++)
            {
                // Prompts to enter the i-th element and read the input
                Console.Write($"Elements - {i + 0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // initialize variables to store the min and max elements
            int max = arr[0];
            int min = arr[0];
            //loop through the array to find the max and min elements
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    //update max if the current element is greater
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    //update min if the curent element is smaller
                    min = arr[i];
                }
            }
            //prints the max and min elements
            Console.WriteLine($"\nMaximum element is: {max} ");
            Console.WriteLine($"Minimum element is: {min} ");
            Console.WriteLine("\n");
        }
    }
}
        
        
    
