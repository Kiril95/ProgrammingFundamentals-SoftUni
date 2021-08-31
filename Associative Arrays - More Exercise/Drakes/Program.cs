using System;
using System.Collections.Generic;
using System.Linq;

namespace Drakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int[]>> dragons
                = new Dictionary<string, Dictionary<string, int[]>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentDrag = new Dictionary<string, int[]>();
                string[] operations = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = operations[0];
                string name = operations[1];
                int dmg = operations[2] == "null" ? 45 : int.Parse(operations[2]);
                int health = operations[3] == "null" ? 250 : int.Parse(operations[3]);
                int armor = operations[4] == "null" ? 10 : int.Parse(operations[4]);
                //Dragons dragon = new Dragons(name, dmg, health, armor);

                if (!dragons.ContainsKey(type))
                {
                    currentDrag.Add(name, new int[] { dmg, health, armor });
                    dragons.Add(type, currentDrag);
                }
                else
                {
                    if (!dragons[type].ContainsKey(name))
                    {
                        dragons[type].Add(name, new int[] { dmg, health, armor });
                    }
                    else
                    {
                        dragons[type][name] = new int[] { dmg, health, armor };
                    }
                }
            }

            foreach (var item in dragons)
            {
                Console.WriteLine($"{item.Key}::({(item.Value.Select(x => x.Value[0]).Average()):F2}" +
                                  $"/{(item.Value.Select(x => x.Value[1]).Average()):F2}" +
                                  $"/{(item.Value.Select(x => x.Value[2]).Average()):F2})");

                foreach (var kvp in item.Value
                    .OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{kvp.Key} -> damage: {kvp.Value[0]}" +
                                      $", health: {kvp.Value[1]}, armor: {kvp.Value[2]}");
                }

            }

        }
    }
}
