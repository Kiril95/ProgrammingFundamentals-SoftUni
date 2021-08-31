using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine()
                   .Split("|", StringSplitOptions.RemoveEmptyEntries)
                   .ToList();

            string command = Console.ReadLine();

            while (command != "Yohoho!")
            {
                string[] operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string act = operations[0];

                if (act == "Loot")
                {                                     
                    // C цикъл чета дължината на стринга и работя с всеки елемент
                    for (int i = 1; i < operations.Length; i++)
                    {
                        if (!loot.Contains(operations[i]))
                        {
                            loot.Insert(0, operations[i]);
                        }
                    }

                }
                else if (act == "Drop")
                {
                    int idx = int.Parse(operations[1]);
                    if (idx < 0 || idx >= loot.Count)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                 
                    string temp = loot.ElementAt(idx);
                    loot.Remove(temp);
                    loot.Add(temp);

                }
                else if (act == "Steal")
                {
                    //List<string> removed = new List<string>(loot);
                    int count = int.Parse(operations[1]);
                    if (loot.Count < count)
                    {                      
                        Console.WriteLine(string.Join(", ",loot));
                        loot.Clear();
                        //removed.RemoveAll(x => x.);

                    }
                    else
                    {
                        // Трябва да си ги взимам в променлива
                        var range = loot.GetRange(loot.Count - count, count);

                        loot.RemoveRange(loot.Count - count, count);
                        Console.WriteLine(string.Join(", ", range));
                    }

                }
                command = Console.ReadLine();

            }
            //ParallelQuery<decimal> avg = loot.Select(x => x.Average());
            // Трябва ни селектор(Select), за да обходим всичко и да вземем средно аритм.
            // защото е Лист и без него ни гърми.
            
            if (loot.Count <= 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double avg = loot.Select(x => x.Length).Average();
                Console.WriteLine($"Average treasure gain: {avg:f2} pirate credits.");
            }          

        }
    }
}
