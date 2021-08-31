using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToList();

            //first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.         
            // 1 2 3 4 5 => 2 3 4 => 3
            // 0 1 2 3 4
            for (int i = 0; i <= numbers.Count; i++)
            {
                if (i >= numbers.Count - 1)
                {
                    break;
                }
                numbers[i] += numbers[numbers.Count - 1];
                //numbers.RemoveAt(i + 1);
                numbers.RemoveAt(numbers.Count - 1);
                //i = -1;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
