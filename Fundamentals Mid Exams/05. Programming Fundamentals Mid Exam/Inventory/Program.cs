using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] operations = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string act = operations[0];
                string item = operations[1];

                if (act == "Collect")
                {
                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }
                   
                }
                else if (act == "Drop")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                                  
                }
                else if (act == "Combine Items")
                {
                    var spl = item.Split(":").ToArray();
                    string old = spl[0];
                    string neww = spl[1];

                    if (inventory.Contains(old))
                    {
                        int idx = inventory.IndexOf(old);
                        inventory.Insert(idx + 1, neww);
                    }
                }

                else if (act == "Renew")
                {
                    if (inventory.Contains(item))
                    {
                        int idx = inventory.IndexOf(item); // Намира индеска на даден елемент
                        string elem = inventory.ElementAt(idx); // Намира елемента на даден индекс
                        inventory.Remove(elem);
                        inventory.Add(elem);           
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
