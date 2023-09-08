namespace AdmissionEligibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the marks obtained in Physics:"); /*prompts to enter marks obtained in physics*/
            int Physicsmarks = Convert.ToInt32(Console.ReadLine()); /*reads input and convert to an integer*/
            Console.Write("Enter the marks obtained in Chemistry:");
            int Chemistrymarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks obtained in Mathematics:");
            int Mathematicsmarks = Convert.ToInt32(Console.ReadLine());
            int totalmarks = Physicsmarks + Chemistrymarks + Mathematicsmarks;
            //calculate the totalmarks by adding marks obtained in all 3 subjects
            //if statement checks weather the marks obtained in each subject and total met the eligibility criteria
            if (Physicsmarks >= 55 && Chemistrymarks >= 50 && Mathematicsmarks >= 65 && totalmarks >= 180)
            {
                Console.WriteLine("The canidate is eligible for admission.");
                //prints a message that the canidate is eligible for admission
            }
            else if (totalmarks  >= 140)
            {
                Console.WriteLine("The canidate is eligible for admission.");
                //prints a message that the canidate is eligible for admission
            }
            else
            {
                Console.WriteLine("The canidate is not eligible for admission.");
                //prints a message that the canidate is not eligible for admission 
            }
            
        }

    }   
        
}