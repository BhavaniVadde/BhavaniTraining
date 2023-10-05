namespace _7CreateWriteLines
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\n Create and write some line of text which does not contain a given string in a line : \n");
            Console.Write("------------------------------------------------------------------------------------------------\n");
            
            Console.Write("Input the string to ignore the line : ");
            string str = Console.ReadLine() ?? "";
            Console.Write("Input number of lines to write in the file: ");
            int numLines = Convert.ToInt32(Console.ReadLine());

            string[] lines = new string[numLines];

            for (int i = 0; i < numLines; i++)
            {
                Console.Write($"Input line {i + 1}: ");
                lines[i] = Console.ReadLine() ?? "";
            }
            string filePath = "output.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains(str))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.Write("\nThe line has ignored which contain the string '{0}'. ", str);
                Console.Write("\n\nThe content of the file is:\n");
                Console.Write("----------------------------------\n");

                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}