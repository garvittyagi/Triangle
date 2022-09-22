namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input side 1 of triangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            double side3 = Convert.ToDouble(Console.ReadLine());



            if (side1 == side2 && side2 == side3)
                Console.WriteLine("This is an equilateral triangle.");

            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("This is an isosceles triangle.");
            
            else
                Console.WriteLine("This is a scalene triangle.");
        }
    }
}