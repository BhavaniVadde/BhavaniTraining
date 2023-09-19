namespace _11List
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Sample input list of integers
            List<int> originalList = new List<int> { 10, 22, 35, 47, 53, 67 };

            // Create a new list by filtering out values ending with 7
            List<int> filteredList = FilterValuesEndingWith7(originalList);

            // Print the filtered list
            Console.WriteLine(string.Join(" ", filteredList));
        }

        // Function to filter out values ending with 7
        static List<int> FilterValuesEndingWith7(List<int> originalList)
        {
            List<int> resultList = originalList.Where(num => num % 10 != 7).ToList();
            return resultList;
        }
    }
}