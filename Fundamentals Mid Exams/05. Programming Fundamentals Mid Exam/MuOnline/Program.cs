using System;
using System.Collections.Generic;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            int bitCoins = 0;
            int bestRoom = 0;
            int health = 100;

            for (int i = 0; i < rooms.Count; i++)
            {
                List<string> newRoom = rooms[i].Split(" ").ToList(); // Когато искаме да "доразбием" масива
                string command = newRoom[0];
                int num = int.Parse(newRoom[1]);

                if (command == "potion")
                {
                    var test = 100 - health;
                    health += num; // 120(90)
                    if (health > 100)
                    {
                        health -= num;
                        health += test;
                        Console.WriteLine($"You healed for {test} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {num} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }

                else if (command == "chest")
                {
                    bitCoins += num;
                    Console.WriteLine($"You found {num} bitcoins.");
                }

                else
                {
                    health -= num;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }

                }

            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitCoins}");
            Console.WriteLine($"Health: {health}");

        }
    }
}
