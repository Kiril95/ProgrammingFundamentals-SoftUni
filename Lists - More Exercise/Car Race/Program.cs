using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToList();

            double left = 0;
            double right = 0;
            var first = numbers.Take(numbers.Count / 2).ToList();
            var second = numbers.Skip((numbers.Count + 1) / 2).Reverse().ToList();
            //var ar = numbers.GetRange(0, numbers.Count / 2);

            for (int i = 0; i < first.Count; i++)
            {
                if (first[i] == 0)
                {
                    left *= 0.80;
                    continue;
                }
                left += first[i];
            }

            for (int i = 0; i < second.Count; i++)
            {
                if (second[i] == 0)
                {
                    right *= 0.80;
                    continue;
                }
                right += second[i];
            }
            if (left < right)
            {
                Console.WriteLine($"The winner is left with total time: {left}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {right}");
            }
            
        }

    }
}
