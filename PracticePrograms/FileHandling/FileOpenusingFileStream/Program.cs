using System.Text;


namespace FileOpenusingFileStream
{
    internal class Program
    {
        static void Main()
        {
            string FilePath = @"D:\MyFile.txt";
            FileStream fileStream = new FileStream(FilePath, FileMode.Create);
            fileStream.Close();
            byte[] bytedata = Encoding.Default.GetBytes("C# is an Object Oriented Programming Language");
            fileStream.Write(bytedata, 0, bytedata.Length);
            fileStream.Dispose();
            Console.WriteLine("Succesfully saved file with data : C# is an Object Oriented Programming Language");
            Console.ReadKey();
        }
    }
}