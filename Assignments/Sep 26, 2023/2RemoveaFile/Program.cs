namespace RemoveaFile
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("\n\n Remove a File from the disk: \n");
            Console.Write("------------------------------------\n");
            string FilePath = @"D:\MyDevFile.txt";
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
                Console.WriteLine("\n\n File deleted successfully. ");
            }
            else
            {
                Console.WriteLine(" File does not exists. ");
            }

        }
    }
}