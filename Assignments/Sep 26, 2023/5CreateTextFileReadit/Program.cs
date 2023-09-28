namespace _5CreateTextFileReadit
{
    public class Program
    {
        static void Main()
        {
            Console.Write("\n\n Create a Text File and Read the File: \n");
            Console.Write("-------------------------------------------\n");
            string FilePath = @"D:\MyDevFile.txt";
            StreamWriter streamWriter = new StreamWriter(FilePath);
            Console.WriteLine("\n Enter the text to write the file ");
            string? inputData = Console.ReadLine();
            streamWriter.WriteLine(inputData);
            Console.WriteLine("Data has been written to the file");
            streamWriter.Close();  
            Console.ReadKey();
        }
    }
}