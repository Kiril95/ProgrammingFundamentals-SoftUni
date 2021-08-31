using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<double> numbers = Console.ReadLine()
            //     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //     .Select(double.Parse)
            //     .Where(n => n >= 0)  //Връща true or false. N = предикат.
            //     .Reverse()
            //     .ToList();
            //
            // if (numbers.Count != 0)
            // {
            //     Console.WriteLine(string.Join(" ", numbers));
            // }
            // else
            // {
            //     Console.WriteLine("empty");
            // }

            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            numbers.RemoveAll(n => n < 0);
            numbers.Reverse();

            if (numbers.Count != 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
