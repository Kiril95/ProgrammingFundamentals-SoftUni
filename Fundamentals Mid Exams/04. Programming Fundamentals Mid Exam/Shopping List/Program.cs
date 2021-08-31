using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                   .Split("!", StringSplitOptions.RemoveEmptyEntries)
                   .ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string act = operations[0];
                string product = operations[1];

                if (act == "Urgent")
                {
                    if (!groceries.Contains(product))
                    {
                        groceries.Insert(0, product);
                    }

                }
                else if (act == "Unnecessary")
                {
                    if (groceries.Contains(product))
                    {
                        groceries.Remove(product);
                    }

                }
                else if (act == "Correct")
                {
                    string old = operations[1];
                    string neww = operations[2];

                    if (groceries.Contains(old))
                    {
                        int idx = groceries.IndexOf(old);
                        groceries[idx] = neww;
                    }
                }

                else if (act == "Rearrange")
                {
                    if (groceries.Contains(product))
                    {
                       int idx = groceries.IndexOf(product);
                       string elem = groceries.ElementAt(idx);
                        //groceries.Insert(groceries.Count, product);
                       groceries.Remove(elem);
                       groceries.Add(elem);
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
