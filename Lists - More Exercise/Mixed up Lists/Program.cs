using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_up_Lists
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
                .Reverse()
                .ToList();

            List<int> start = new List<int>();
            List<int> end = new List<int>();
            List<int> newList = new List<int>();
            List<int> result = new List<int>();
  
            if (first.Count > second.Count)
            {
                start = first;
                end = second;
            }
            else
            {
                start = second;
                end = first;
            }

            for (int i = 0; i < start.Count; i++)
            {
                i = 0;
                if (start.Count <= 2)
                {
                    break;
                }
                newList.Add(start[i]);
                start.RemoveAt(0);
            }

            for (int j= 0; j < end.Count; j++)
            {
                newList.Add(end[j]);
            }

            var a = start[0];
            var b = start[1];
            var bigger = Math.Max(a, b);
            var smaller = Math.Min(a, b);

           // for (int i = 0; i < newList.Count; i++) 
           // {
           //     if (newList[i] > smaller && newList[i] < bigger)
           //     {
           //         result.Add(newList[i]);
           //     }
           // }
            List<int> FIN = newList
            .Where(x => (x > smaller && x < bigger))
            .OrderBy(x => x)
            .ToList();

            //var final = result.OrderBy(x => x); // or result.Sort();
            Console.WriteLine(string.Join(" ", FIN));

        }
    }
}
