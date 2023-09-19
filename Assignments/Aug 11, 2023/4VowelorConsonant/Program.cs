namespace VowelorConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a small alphabet letter:");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                Console.WriteLine("Vowel");
            else Console.WriteLine("Consonant");
        }
        
    }
}
