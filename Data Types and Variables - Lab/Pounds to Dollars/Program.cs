using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal result = pounds * 1.31M;

            Console.WriteLine($"{result:f3}");
        }
    }
}
