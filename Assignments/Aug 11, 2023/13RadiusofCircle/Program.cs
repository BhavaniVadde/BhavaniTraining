namespace RadiusofCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Radious of Circle : ");
            double Radious = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radious * Radious;
            double Perimeter = 2 * Math.PI * Radious;
            Console.WriteLine("Area of circle: " + Area);
            Console.WriteLine("Perimeter of Circle: " + Perimeter);
            Console.ReadKey();
        }
    }
}