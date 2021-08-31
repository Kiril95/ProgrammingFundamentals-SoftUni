using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> main = new Dictionary<string, List<string>>();
            Dictionary<string, string> secondary = new Dictionary<string, string>();
            //var users = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "Lumpawaroo")
            {
                if (command.Contains(" | "))
                {
                    string[] operations = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string side = operations[0];
                    string user = operations[1];
                    if (!secondary.ContainsKey(user))
                    {
                        if (!main.ContainsKey(side))
                        {
                            main.Add(side, new List<string>());                          
                        }                                          
                        main[side].Add(user);
                        secondary.Add(user, side);
                    }
                }
                else if (command.Contains(" -> "))
                {
                    string[] operations = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string user = operations[0];
                    string side = operations[1];

                    //If you receive a forceUser->forceSide, you should check if there 
                    //    is such a forceUser already and if so, change his/ her side.
                    //    If there is no such forceUser, add him/ her to the corresponding 
                    //    forceSide, treating the command as a new registered forceUser.
                    if (!main.ContainsKey(side))
                    {
                        main.Add(side, new List<string>());
                    }
                    if (secondary.ContainsKey(user))
                    {
                        //Взимам данните, които са ми нужни от втория Речник и работя по-лесно
                        var tempSide = secondary[user];
                        main[tempSide].Remove(user);
                        main[side].Add(user);
                        secondary[user] = side;

                    }
                    else
                    {
                        main[side].Add(user);
                        secondary.Add(user, side);
                    }
                    Console.WriteLine($"{user} joins the {side} side!");

                }

                command = Console.ReadLine();

            }
            var ordered = main
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in ordered)
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count()}");

                //item.Value.Sort();
                //Когато KVP двойките трябва да ги отпечатваме на нов ред, следва да
                //направим вложен foreach и обхождаме всичко във Value частта, 
                //като използваме променливата от първия цикъл

                foreach (var value in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {value}");
                }

            }

        }
    }
}
