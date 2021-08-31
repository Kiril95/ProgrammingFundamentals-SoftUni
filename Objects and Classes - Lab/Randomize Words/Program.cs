using System;
using System.Collections.Generic;
using System.Linq;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> line = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .ToList();

            Random rnd = new Random(); // Клас - рандом

            for (int i = 0; i < line.Count; i++)
            {
                int idx = rnd.Next(0, line.Count);

                string a = line[idx];
                string b = line[i];

                line[idx] = b;
                line[i] = a;
            }
            foreach (var item in line)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(string.Join("/n", line));
        }
    }
}
