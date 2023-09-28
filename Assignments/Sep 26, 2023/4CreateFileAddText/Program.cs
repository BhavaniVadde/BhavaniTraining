using System.Runtime.CompilerServices;
using System.Text;

namespace CreateFileAddText
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("\n\n Create a File and Add Some Text.\n");
            Console.Write("---------------------------------------\n");
            string FilePath = @"D:\MyDevFile.txt";
            
            FileStream fileStream = new FileStream(FilePath, FileMode.Append);
            byte[] bytedata = Encoding.Default.GetBytes("Accionlabs is at 7th floor in Gamma Block.");
            fileStream.Write(bytedata, 0, bytedata.Length);
            fileStream.Close();
            Console.Write("\nSuccessfully file saved with data : Accionlabs is at 7th floor in Gamma Block.");
            Console.ReadKey();
            
        }
    }
}