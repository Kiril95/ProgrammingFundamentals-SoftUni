using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToList();

            
            
            
            List<int> second = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToList();

            List<int> resultList = new List<int>();

            int lengthMin = Math.Min(first.Count, second.Count);
            int lengthMax = Math.Max(first.Count, second.Count);

            if (first.Count >= second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    resultList.Add(first[i]);
                    if (i < second.Count)
                    {
                        resultList.Add(second[i]);
                    }
                }
            }

            else
            {
                for (int i = 0; i < second.Count; i++)
                {
                    if (i < first.Count)
                    {
                        resultList.Add(first[i]);
                    }
                    resultList.Add(second[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
