namespace CreateaBlankFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n Create a Blank File on the disk: \n ");
            Console.Write("-------------------------------------\n");

            //Set the file path where you want to create the file in your disk
            string FilePath = @"D:\MyDevFile.txt";

            //Create an instance of fileStream class By specifying the file Path and file Mode
            //FileMode is going to be create as we are going to create a new file
            FileStream fileStream = new FileStream(FilePath, FileMode.Create);

            //Finally close the filestream Object
            fileStream.Close();

            Console.Write("\n\n File has been created and the Path - D:\\MyDevFile.txt");

            Console.ReadKey();
        }
    }
}