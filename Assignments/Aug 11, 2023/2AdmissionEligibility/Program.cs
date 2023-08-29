namespace AdmissionEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the marks obtained in Physics:");
            int Physicsmarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks obtained in Chemistry:");
            int Chemistrymarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the marks obtained in Mathematics:");
            int Mathematicsmarks = Convert.ToInt32(Console.ReadLine());
            int totalmarks = Physicsmarks + Chemistrymarks + Mathematicsmarks;
            if ( Physicsmarks >= 55 && Chemistrymarks >= 50 && Mathematicsmarks >= 65 && totalmarks >= 180 )
            {
                Console.WriteLine("The canidate is eligible for admission.");
            }
            else if ( Mathematicsmarks + Physicsmarks >= 140 )
            {
                Console.WriteLine("The canidate is eligible for admission.");
            }
            Console.WriteLine("The canidate is not eligible for admission.");

        }
    }
}