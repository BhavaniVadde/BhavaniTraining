namespace _9Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Sample input list of integers
            List<int> originalList = new List<int>() { 1,2,3,4};
            // Create a new list by multiplying each element by 3
            List<int> multipliedList = MultiplyByThree(originalList);
            // Print the new list
            Console.WriteLine("New array:" + string.Join(" ",multipliedList));
        }
        // Function to multiply each element of the input list by 3
        static List<int>MultiplyByThree(List<int> originalList)
        {
            List<int> resultList = new List<int>();
            foreach (int num in originalList)
            {
                int multipliedValue = num * 3;
                resultList.Add(multipliedValue);
            }
            return resultList;
        }
    }
}