using System.Reflection.Metadata;

namespace RadiusofCircle
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //prompts to enter radius and diplays input radius
            Console.Write("Input the Radius of the Circle : ");
            //reads input radius and converts to double and store in radius
            double Radius = Convert.ToDouble(Console.ReadLine());

            //calculates the area and perimeter of the circle
            double Area = Math.PI * Radius * Radius;
            double Perimeter = 2 * Math.PI * Radius;
            //using string format, prints the area and perimeter of circle, and displays
            Console.WriteLine("Area of Circle= {0} ", string.Format("{0:0.00}", Area));
            Console.WriteLine("Perimeter of Circle={0} ", string.Format("{0:0.00}", Perimeter));
            //waits to press anykey before its exits
            Console.ReadKey();
        }
    }
}