using Microsoft.VisualBasic;
using System.Security.Cryptography;

namespace CheckUserIDPassword
{
    public class Program
    {
        static void Main(string[] args)
        {    
           // Declared 2 nullable string variables username and password
            string? username, password;

           // Declared two integer varibles crt&dd and initialized both the values'0'
           // crt is used to keep track login attempts and
           // dd will be used to indicate weather the login was successful  
            int ctr = 0, dd = 0;

            //Displays introductory message 
            Console.Write("\n\nCheck username and password :\n");
            // Displays default login credentials.
            Console.Write(" Defaule username and password is : username and password\n");
            Console.Write("---------------------------------------------------------\n");
            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();
                if (username == "username" && password == "password")
                {
                    dd = 1;// Set 'dd' to 1 to indicate a successful login.
                    ctr = 3;//  Set 'ctr' to 3 to exit the login loop.
                }

                else
                {
                    dd = 0;// Set 'dd' to 0 to indicate an unsuccessful login.
                    ctr++;// Increment 'ctr' to keep track of login attempts.
                }
            }
            while ((username != "username" || password != "password") && (ctr != 3));
            if (dd == 0)
            {
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            }
            else
            if (dd == 1)
            {
                Console.Write("\nPassword entered successfull!\n\n");
            }
        }
    }
}


        