namespace VariableDataToFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\MyFile.txt";
            
            int a, b, result;
            a = 15;
            b = 20;
            result = a + b;
            
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.Write($"Sum of {a} + {b} = {result}");
                //No need to call the Flush and Close Method
            }
            Console.WriteLine("Variable Data is Saved into the File");
            Console.ReadKey();
        }
    }
}