using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {                               
            List<string> biscuitsToPurchase = Console.ReadLine()
                   .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                   .ToList();

            string command = Console.ReadLine();

            while (command != "No More Money")
            {
                string[] operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string act = operations[0];
                string biscuit = operations[1];

                if (act == "OutOfStock")
                {
                    //biscuitsToPurchase.RemoveAll(x => x == biscuit);
                    for (int i = 0; i < biscuitsToPurchase.Count; i++)
                    {
                        if (biscuitsToPurchase[i] == biscuit)
                        {
                            biscuitsToPurchase[i] = "None";
                        }
                    }

                }
                else if (act == "Required")
                {
                    int idx = int.Parse(operations[2]);
                    //var elem = biscuitsToPurchase.ElementAt(idx);
                    if (idx >= 0 && idx < biscuitsToPurchase.Count &&
                        biscuitsToPurchase[idx] != "None")
                    {
                        biscuitsToPurchase[idx] = biscuit;
                    }

                }
                else if (act == "Last")
                {
                    biscuitsToPurchase.Add(biscuit);
                }
                command = Console.ReadLine();

            }
            var newList = biscuitsToPurchase.Where(x => x != "None").ToList();
            Console.WriteLine(string.Join(" ", newList));

        }
    }
}
