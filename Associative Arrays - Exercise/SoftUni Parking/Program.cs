using System;
using System.Collections.Generic;
using System.Resources;
using System.Threading;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ");
                string act = command[0];
                string name = command[1];

                if (act == "register")
                {
                    string plate = command[2];
                    if (!result.ContainsKey(name))
                    {
                        result.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");    
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                }
                else if (act == "unregister")
                {
                    if (result.ContainsKey(name))
                    {
                        result.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }

            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }


        }
    }
}
