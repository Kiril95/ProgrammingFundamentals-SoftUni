using System;

namespace Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            decimal result = num / 1000;
            Console.WriteLine($"{result:f2}");
        }
    }
}
