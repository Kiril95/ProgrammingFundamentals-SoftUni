using System;
using System.Collections.Generic;
using System.Linq;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToList();

            List<string> test = new List<string>();

            numbers.FindIndex(x => x % 2 == 0); // Намира първия индекс, който отговаря на условието

        }
    }
}
