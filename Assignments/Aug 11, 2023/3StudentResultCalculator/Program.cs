namespace StudentResultCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //declares variables to store student information and marks
            int rollnumber; 
            string? name;
            int physicsMarks, chemistryMarks, computerMarks;
            double totalMarks, percentage;
            string division;
            //prompts to input rollnum and reads the input,converts to an integer 
            Console.Write("Input the Roll Number of the student:");
            rollnumber = Convert.ToInt32(Console.ReadLine());
            //prompts to input student name and reads it as a string
            Console.Write("Input the name of the Student:");
            name = Console.ReadLine();
            Console.Write("Input the marks in Physics:");
            physicsMarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks in Chemistry:");
            chemistryMarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks in Computer:");
            computerMarks = Convert.ToInt32(Console.ReadLine());
            //Calculates total marks by adding the marks in phy,chem and comp
            totalMarks = physicsMarks + chemistryMarks + computerMarks;
            //calculates the percentage by dividing totalmarks by 300 and multiplying by 100
            percentage = (totalMarks / 300) * 100;
            //determines student division based on their percentage
            if (percentage >= 60)
            {
                division = "First";
            }
            else if (percentage >= 45)
            {
                division = "Second";
            }
            else
            {
                division = "Fail";
            }
            //displays student's information and results
            Console.WriteLine($"Roll No : {rollnumber}");
            Console.WriteLine($"Name of the Student : {name}");
            Console.WriteLine($"Marks in Physics : {physicsMarks}");
            Console.WriteLine($"Marks in Chemistry : {chemistryMarks}");
            Console.WriteLine($"Marks in Computer : {computerMarks}");
            Console.WriteLine($"Total Marks = {totalMarks}");
            Console.WriteLine("Percentage = {0}", string.Format("{0:0.00}", percentage));
            Console.WriteLine($"Division = {division}");
            // Waits to press any key before exiting
            Console.ReadLine();
        }
    }
}