using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;

namespace Judge
{
    //class Info
    //{
    //    public Info(string name, int points)
    //    {
    //        Name = name;
    //        Points = points;                //Конструкторчее
    //    }
    //    public string Name { get; set; }
    //    public int Points { get; set; }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> individuals = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();

            while (command != "no more time")
            {
                string[] operations = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string name = operations[0];
                string contest = operations[1];
                int points = int.Parse((operations[2]));

                if (result.ContainsKey(contest))
                {
                    if (result[contest].ContainsKey(name))
                    {
                        if (result[contest][name] < points)
                        {
                            result[contest][name] = points;
                        }
                    }
                    else
                    {
                        result[contest].Add(name, points);
                    }
                }

                else
                {
                    result.Add(contest, new Dictionary<string, int> {{name, points}});
                }

                if (!individuals.ContainsKey(name))
                {
                    individuals.Add(name, new Dictionary<string, int> { { contest, points } });
                }

                else
                {
                    if (individuals[name].ContainsKey(contest))
                    {
                        if (individuals[name][contest] < points)
                        {
                            individuals[name][contest] = points;
                        }
                        else
                        {
                            individuals[name][contest] += points;
                        }
                    }
                    else
                    {
                        individuals[name].Add(contest, points);
                    }
                }

                command = Console.ReadLine();
                
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()} participants");
                int count = 1;

                foreach (var kvp in item.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{count}. {kvp.Key} <::> {kvp.Value}");
                    count++;
                }
            }

            var sorted = individuals
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key);

            Console.WriteLine("Individual standings:");
            int i = 1;
            foreach (var item in sorted)
            {
                Console.WriteLine($"{i}. {item.Key} -> {item.Value.Values.Sum()}");
                i++;
            }
        }
    }
}
