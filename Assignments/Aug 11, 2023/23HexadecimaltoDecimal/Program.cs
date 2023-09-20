namespace HexadecimaltoDecimal
{
    public class Program
    {
        static void Main(string[] args)
        {
 // Declare a string variable 'hex_value' and initialize it with the hexadecimal string "4B0".
            string hex_value = "4B0";
  // Convert the hexadecimal string 'hex_value' to an integer and store it in 'int_value'.
            int int_value = Convert.ToInt32(hex_value, 16);
 // The 'Convert.ToInt32' method is used with base 16 to specify that the input is in hexadecimal format.
            Console.WriteLine("hex_value = {0}", hex_value);
           // Print the original hexadecimal string 'hex_value' to the console.
            Console.WriteLine("int_value = {0}", int_value);
            // Print the converted integer 'int_value' to the console.
           Console.ReadLine();
        }
    }
}