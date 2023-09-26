namespace FileUsingSreamWriter
{
    internal class Program
    {
        static void Main()
        {
            StreamWriter streamWriter = new StreamWriter("D://MyFile.txt");
            Console.WriteLine("Enter the Text that you want to write on File");
            string? inputData = Console.ReadLine();
            streamWriter.Write(inputData);
            Console.WriteLine("Data Has Been Written to the File");
            streamWriter.Flush();
            streamWriter.Close();
            Console.ReadKey();
        }
    }
}