using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_New_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> presents = new Dictionary<string, int>();
            Dictionary<string, int> kids = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] operations = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
               
                if (operations[0] == "Remove")
                {
                    kids.Remove(operations[1]);
                }
                else
                {
                    string name = operations[0];
                    string gift = operations[1];
                    int amount = int.Parse(operations[2]);

                    if (kids.ContainsKey(name))
                    {
                        kids[name] += amount;
                    }
                    else
                    {
                        kids.Add(name, amount);
                    }

                    if (presents.ContainsKey(gift))
                    {
                        presents[gift] += amount;
                    }
                    else
                    {
                        presents.Add(gift, amount);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Children:");
            foreach (var item in kids.OrderByDescending(x => x.Value)
                                     .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine("Presents:");
            foreach (var item in presents)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
