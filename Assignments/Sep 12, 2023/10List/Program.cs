namespace _10List
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                // Sample input list of positive integers
                List<int> originalList = new List<int> { 10, 22, 35, 41 };

                // Create a new list with rightmost digits
                List<int> rightmostDigitsList = GetRightmostDigits(originalList);

                // Print the list of rightmost digits
                Console.WriteLine(string.Join(" ", rightmostDigitsList));
            }

            // Function to extract the rightmost digits from the input list
            static List<int> GetRightmostDigits(List<int> originalList)
            {
                List<int> resultList = new List<int>();

                foreach (int num in originalList)
                {
                    int rightmostDigit = num % 10;
                    resultList.Add(rightmostDigit);
                }

                return resultList;
            }
        }
    }
}
    
