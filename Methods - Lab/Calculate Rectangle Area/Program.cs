using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Area(width, height)}");

            static double Area(double width, double height)
            {
                return  width * height;
            }
        }
    }
}
