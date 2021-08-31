using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> game 
                = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "Season end")
            {
                if (command.Contains("->"))
                {
                    string[] operations = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string player = operations[0];
                    string lane = operations[1];
                    int skill = int.Parse((operations[2]));

                    if (game.ContainsKey(player))
                    {
                        if (game[player].ContainsKey(lane)) //Влизам в КвП двойката
                        {
                            if (game[player][lane] < skill)
                            {
                                game[player][lane] = skill;
                            }
                        }
                        else
                        {
                            game[player].Add(lane, skill);
                        }
                    }
                    else
                    {
                        game.Add(player, new Dictionary<string, int>{{lane, skill}});
                    }
                }

                else if (command.Contains("vs"))
                {
                    string[] operations = command.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string first = operations[0];
                    string second = operations[1];

                    if (game.ContainsKey(first) && game.ContainsKey(second))
                    {
                        string playerToRemove = "";
                        foreach (var item in game[first])
                        {
                            foreach (var kvp in game[second])
                            {
                                if (item.Key == kvp.Key)
                                {
                                    if (game[first].Values.Sum() > game[second].Values.Sum())
                                    {
                                        playerToRemove = second;
                                    }
                                        
                                    else if (game[first].Values.Sum() < game[second].Values.Sum())
                                    {
                                        playerToRemove = first;
                                    }
                                }
                            }
                        }
                        game.Remove(playerToRemove);
                    }
                    
                }
                command = Console.ReadLine();
            }

            foreach (var item in game
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");

                foreach (var pair in item.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {pair.Key} <::> {pair.Value}");
                }
            }
        }
    }
}
