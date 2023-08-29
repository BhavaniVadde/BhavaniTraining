namespace StudentResultCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollnumber;
            string name;
            int physicsMarks, chemistryMarks, computerMarks;
            double totalMarks, percentage;
            string division;
            Console.Write("Input the Roll Number of the student:");
            rollnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the Student:");
            name = Console.ReadLine();
            Console.Write("Input the marks in Physics:");
            physicsMarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks in Chemistry:");
            chemistryMarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks in Computer:");
            computerMarks = Convert.ToInt32(Console.ReadLine());
            totalMarks = physicsMarks + chemistryMarks + computerMarks;
            percentage = totalMarks / 300 * 100;
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
            Console.WriteLine($"Roll No : {rollnumber}");
            Console.WriteLine($"Name of the Student : {name}");
            Console.WriteLine($"Marks in Physics : {physicsMarks}");
            Console.WriteLine($"Marks in Chemistry : {chemistryMarks}");
            Console.WriteLine($"Marks in Computer : {computerMarks}");
            Console.WriteLine($"Total Marks = {totalMarks}");
            Console.WriteLine($"Percentage = {percentage:F2} ");
            Console.WriteLine($"Division = {division}");
            Console.ReadLine();
        }
    }
}