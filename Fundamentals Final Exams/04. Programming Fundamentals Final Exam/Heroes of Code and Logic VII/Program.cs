using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII
{
    class Stats
    {
        public Stats(int health, int mana)
        {
            Health = health;
            Mana = mana;                //Конструкторчее
        }
        public int Health { get; set; }
        public int Mana { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Stats> heroes = new Dictionary<string, Stats>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = line[0];
                int health = int.Parse(line[1]);
                int mana = int.Parse(line[2]);

                heroes.Add(name, new Stats(health, mana));
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] operations = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string name = operations[1];

                if (operations[0] == "CastSpell")
                {
                    int manaCost = int.Parse(operations[2]);
                    string spell = operations[3];

                    if (heroes[name].Mana >= manaCost)
                    {
                        heroes[name].Mana -= manaCost;
                        Console.WriteLine($"{name} has successfully cast {spell} and now has {heroes[name].Mana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
                    }

                }
                else if (operations[0] == "TakeDamage")
                {
                    int damage = int.Parse(operations[2]);
                    string attacker = operations[3];

                    heroes[name].Health -= damage;
                    if (heroes[name].Health > 0)
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name].Health} HP left!");
                    }
                    else
                    {
                        heroes.Remove(name);
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                    }

                }
                else if (operations[0] == "Recharge")
                {
                    int amount = int.Parse(operations[2]);

                    if (heroes[name].Mana + amount > 200)
                    {
                        Console.WriteLine($"{name} recharged for {200 - heroes[name].Mana} MP!");
                        heroes[name].Mana = 200;
                    }
                    else
                    {
                        heroes[name].Mana += amount;
                        Console.WriteLine($"{name} recharged for {amount} MP!");
                    }

                }
                else if (operations[0] == "Heal")
                {
                    int amount = int.Parse(operations[2]);

                    if (heroes[name].Health + amount > 100)
                    {
                        Console.WriteLine($"{name} healed for {100 - heroes[name].Health} HP!");
                        heroes[name].Health = 100;
                    }
                    else
                    {
                        heroes[name].Health += amount;
                        Console.WriteLine($"{name} healed for {amount} HP!");
                    }

                }
                command = Console.ReadLine();
            }
            heroes = heroes
                .OrderByDescending(x => x.Value.Health)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in heroes)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value.Health}");
                Console.WriteLine($"  MP: {item.Value.Mana}");
            }

        }
    }
}
