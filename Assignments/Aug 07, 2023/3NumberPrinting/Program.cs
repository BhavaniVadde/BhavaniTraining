namespace NumberPrinting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 1 and 5:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 5)
            {
                Console.WriteLine("Using for loop:");
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Using foreach loop:");
                int[] numbersArrays = new int[number];
                for (int i = 0; i < number; i++)
                {
                    numbersArrays[i] = i + 1;
                }
                foreach (int num in numbersArrays)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Using while loop:");
                int count = 1;
                while (count < number)
                {
                    Console.WriteLine(count + " ");
                    count++;
                }
                Console.WriteLine();

                Console.WriteLine("Using do while loop");
                int docount = 1;
                do
                {
                    Console.Write(docount + " ");
                    docount++;
                }while (docount <= number);

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 5.");
            }

        }
    }
}

        
    

