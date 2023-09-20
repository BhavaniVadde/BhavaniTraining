namespace NumberPattern
{
  public class Program
    {
        static void Main(string[] args)
        { 
            int n = 4; /*declare an integer and initialized its value 4*/ 
            //outer loop controls no.of rows in the pattern
            for (int i = 1; i <= n; i++)
            {   
                //controls No.of columns in each row and prints in ascending order  
                for (int j = 1; j <= i; j++)
                {   
                    //prints value of j, without moving to next line and prints pattern in each row
                    Console.Write(j);
                }
                //prints new line by moving to create next row in pattern
                Console.WriteLine();
            }
        }
    }
}