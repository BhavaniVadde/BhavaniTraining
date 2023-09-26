namespace FileCreationUsingFileStream
{
    internal class Program
    {
        static void Main()
        {
            //Set the file path where you want to create the file in your disk
            string FilePath = @"D:\MyFile.txt";

            //Create an instance of fileStream class By specifying the file Path and file Mode
            //FileMode is going to be create as we are going to create a new file
            FileStream fileStream = new FileStream(FilePath, FileMode.Create);

            //Finally close the filestream Object
            fileStream.Close();

            Console.Write("File has been created and the Path is D:\\MyFile.txt");

            Console.ReadKey();

        }
    }
}

