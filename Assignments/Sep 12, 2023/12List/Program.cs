namespace _12List
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Sample input list of strings
            List<string> originalList = new List<string> { "Abc", "cdef", "js", "php" };

            // Create a new list with strings in uppercase
            List<string> upperCaseList = ConvertToUpperCase(originalList);

            // Print the list with uppercase strings
            Console.WriteLine(string.Join(" ", upperCaseList));
        }

        // Function to convert strings in the input list to uppercase
        static List<string> ConvertToUpperCase(List<string> originalList)
        {
            List<string> resultList = new List<string>();

            foreach (string str in originalList)
            {
                string upperCaseStr = str.ToUpper();
                resultList.Add(upperCaseStr);
            }

            return resultList;
        }
    }
}