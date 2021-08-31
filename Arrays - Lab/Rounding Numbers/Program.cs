using System;
using System.Linq;
using System.Numerics;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            foreach (double item in numbers)
            {
                double round = Math.Round(item, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(item)}" +
                    $" => {Convert.ToDecimal(round)}");
            }
            //if (numbers[i] == 0)
            //{
            //    if (numbers[i] != 0)
            //    {
            //        
            //    }
            //}


        }
    }
}
