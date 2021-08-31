using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split("|")
                .Reverse()
                .ToList();
        
            List<string> final = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                List<string> splitNums = numbers[i].Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();

                foreach (var item in splitNums)
                {
                    final.Add(item);
                    //Console.Write($"{splitNums[j]} ");
                }
            }

            Console.WriteLine(string.Join(" ", final));
        }
    }
}
