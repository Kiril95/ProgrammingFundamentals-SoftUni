using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            //List<double> newList = new List<double>();
            int n = 0;
            while (n < numbers.Count - 1)
            {
                if (numbers[n] == numbers[n + 1])
                {
                    numbers[n] += numbers[n + 1];
                    numbers.RemoveAt(n + 1);
                    n = 0;
                    continue;
                }
                n++;
            }
                    
            Console.WriteLine(string.Join(" ", numbers));         
        }
    }
}
