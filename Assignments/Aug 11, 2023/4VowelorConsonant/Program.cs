using System;

namespace VowelorConsonant
{
  public class Program
    {
     static void Main()
     {
       //prompts to enter small letter and displays text
       Console.WriteLine("Enter a small alphabet letter:");
       //Reads input text and converts to the input string to a char type, assigs to the variable ch
      char ch = Convert.ToChar(Console.ReadLine());
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
           Console.WriteLine("Vowel");
        else 
           Console.WriteLine("Consonant");
     }
        
    }
}
