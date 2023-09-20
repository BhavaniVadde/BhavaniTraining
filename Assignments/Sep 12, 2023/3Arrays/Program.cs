namespace _3Arrays
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of values(n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            // Creates an integer array of size n 
            int[] arr = new int[n];
            // Loop to input n elements into the array
            for (int i = 0; i < n; i++)
            {
                // Prompts to enter the ith element and read the input
                Console.Write($"Elements - {i + 0 }: ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Creates a dictionary to store the count of each element
            Dictionary<int,int> elementCount = new Dictionary<int,int>();

            // Counts the occurrences of each element in the array
            foreach (int element in arr)
            {
                if (elementCount.ContainsKey(element))
                {
                    // Increment the count if the element already exists in the dictionary
                    elementCount[element]++;
                }
                else
                {
                    // Add the element to the dictionary with a count of 1 if it doesn't exist
                    elementCount[element] = 1;
                }
            }
            // Loop through the dictionary to find duplicate elements
            foreach (var kvp in elementCount)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine($"\nTotal number of duplicate elements found in array is:{kvp.Key}\n\n ");
                }
            }
            Console.WriteLine();


        }
    }
}