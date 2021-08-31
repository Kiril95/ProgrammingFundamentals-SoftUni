using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Info
    {
        public Info(int population, int gold)
        {
            Population = population;
            Gold = gold;                //Конструкторчее
        }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, Info> result = new Dictionary<string, Info>();

            while (line != "Sail")
            {
                string[] operations = line.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string town = operations[0];
                int population = int.Parse(operations[1]);
                int gold = int.Parse(operations[2]);

                if (!result.ContainsKey(town))
                {
                    result.Add(town, new Info(population, gold));
                }
                else
                {
                    result[town].Population += population;
                    result[town].Gold += gold;
                }           
                line = Console.ReadLine();
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] operations = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = operations[0];
                
                if (action == "Plunder")
                {
                    string town = operations[1];
                    int population = int.Parse(operations[2]);
                    int gold = int.Parse(operations[3]);

                    //int bounty = result[town].Gold -= gold;
                    //int kills = result[town].Population -= population;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");

                    result[town].Gold -= gold;
                    result[town].Population -= population;
                    if (result[town].Gold <= 0 || result[town].Population <= 0)
                    {
                        result.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (action == "Prosper")
                {
                    string town = operations[1];
                    int gold = int.Parse(operations[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        result[town].Gold += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury. " +
                            $"{town} now has {result[town].Gold} gold.");
                    }
                }
                command = Console.ReadLine();
            }
            if (result.Count > 0)
            {
                result = result
                    .OrderByDescending(x => x.Value.Gold)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

               Console.WriteLine($"Ahoy, Captain! There are {result.Count()} wealthy settlements to go to:");

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} " +
                        $"citizens, Gold: {item.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }
}
