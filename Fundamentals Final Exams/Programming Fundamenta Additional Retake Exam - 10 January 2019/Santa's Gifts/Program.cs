using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int current = 0;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                if (counter == n)
                {
                    break;
                }

                string[] operations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                i = current;

                if (operations[0] == "Forward")
                {
                    int steps = int.Parse(operations[1]);
                    if (steps + i < houses.Count)
                    {
                        current = steps + i;
                        houses.RemoveAt(current);
                    }
                    
                }
                else if (operations[0] == "Back")
                {
                    int steps = int.Parse(operations[1]);
                    if (i - steps >= 0)
                    {
                        current = i - steps;
                        houses.RemoveAt(current);
                    }

                }
                else if (operations[0] == "Gift")
                {
                    int idx = int.Parse(operations[1]);
                    int newHouse = int.Parse(operations[2]);

                    if (idx >= 0 && idx < houses.Count)
                    {
                        houses.Insert(idx, newHouse);
                        current = idx;
                    }
                }
                else if (operations[0] == "Swap")
                {
                    int first = int.Parse(operations[1]);
                    int second = int.Parse(operations[2]);
                    int idx1 = houses.IndexOf(first);
                    int idx2 = houses.IndexOf(second);

                    if (idx1 >= 0 && idx1 < houses.Count && idx2 >= 0 && idx2 < houses.Count)
                    {
                         houses[idx1] = second;
                         houses[idx2] = first;
                    }                                    
                }
                else
                {

                }
                counter++;
            }

            Console.WriteLine($"Position: {current}");
            Console.WriteLine($"{string.Join(", ", houses)}");
        }
    }
}
