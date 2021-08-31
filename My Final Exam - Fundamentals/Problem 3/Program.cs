using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int unliked = 0;
            Dictionary<string, List<string>> menu = new Dictionary<string, List<string>>();

            while (command != "Stop")
            {
                string[] operations = command.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string guest = operations[1];
                string meal = operations[2];

                if (operations[0] == "Like")
                {
                    if (menu.ContainsKey(guest))
                    {
                        if (!menu[guest].Contains(meal))
                        {
                            menu[guest].Add(meal);
                        }
                    }
                    else
                    {
                        menu.Add(guest, new List<string> { meal });
                    }
                }

                else if (operations[0] == "Unlike")
                {
                    if (menu.ContainsKey(guest))
                    {
                        if (!menu[guest].Contains(meal))
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                        else
                        {
                            menu[guest].Remove(meal);
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                            unliked++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }
                command = Console.ReadLine();
            }

            menu = menu
                .OrderByDescending(x => x.Value.Count())
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            //var convert = string.Join(", ", menu.Values.Select(x => x.ToString())).ToList();
            foreach (var item in menu)
            {
                if (item.Value.Count() == 0)
                {
                    Console.WriteLine($"{item.Key}: ");
                    break;
                }
                int count = 1;
                Console.Write($"{item.Key}: ");
                
                foreach (var kvp in item.Value)
                {
                    if (item.Value.Count() == 1)
                    {
                        Console.WriteLine($"{kvp}");
                    }
                    else
                    {
                        if (item.Value.Count() == count) 
                        {
                            Console.WriteLine($"{kvp}");
                        }
                        else
                        {
                            Console.Write($"{kvp}, ");
                        }
                    }
                              
                    count++;                  
                }             
            }
           //foreach (var item in menu)
           //{
           //    Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
           //}

            Console.WriteLine($"Unliked meals: {unliked}");
        }
    }
}
