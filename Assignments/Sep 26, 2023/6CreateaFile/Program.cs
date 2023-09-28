namespace _6CreateaFile
{
    public class Program
    {
        static void Main()
        {
            Console.Write("\n\n create a file and write an array of strings to the file: \n");
            Console.Write("-----------------------------------------------------------------\n");
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
                    writer.WriteLine(line);
                }
            }

            Console.Write("\n\nThe content of the file is:\n");
            Console.Write("----------------------------------\n");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("");




        }
    }
}