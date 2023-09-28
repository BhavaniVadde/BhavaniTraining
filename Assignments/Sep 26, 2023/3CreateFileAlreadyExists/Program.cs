namespace CreateFileAlreadyExists
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\nCreate a blank file on the disk if the same file already exists:\n");
            Console.Write("--------------------------------------------------------------------\n");
            string FilePath = @"D:\MyDevFile.txt";
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
              FileStream fileStream = new FileStream(FilePath, FileMode.Create);
              Console.WriteLine("\nFile has been created and Path - D:\\MyDevFile.txt \n");
            
            Console.ReadKey();
        }
    }
}