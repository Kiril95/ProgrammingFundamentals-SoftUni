using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    class Dragons
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public Dragons(string name, int dmg, int health, int armor)
        {
            Name = name;
            Damage = dmg;
            Health = health;
            Armor = armor;
        }
    }
    class DragonsAverage
    {
        public List<int> DmgAvg { get; set; }
        public List<int> HealthAvg { get; set; }
        public List<int> ArmorAvg { get; set; }

        public DragonsAverage(List<int> dmgAvg, List<int> healthAvg, List<int> armorAvg)
        {
            DmgAvg = dmgAvg;
            HealthAvg = healthAvg;
            ArmorAvg = armorAvg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragons>> drakes
                = new Dictionary<string, List<Dragons>>();
            var dumbList = new List<Dragons>();
            Dictionary<string, DragonsAverage> average = new Dictionary<string, DragonsAverage>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] operations = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = operations[0];
                string name = operations[1];
                int dmg = operations[2] == "null" ? 45 : int.Parse(operations[2]);
                int health = operations[3] == "null" ? 250 : int.Parse(operations[3]);
                int armor = operations[4] == "null" ? 10 : int.Parse(operations[4]);
                Dragons dragon = new Dragons(name, dmg, health, armor);

                if (drakes.ContainsKey(type))
                {
                    if (dmg.ToString() == "null")
                    {
                        CheckDmg(drakes, type, dmg, dragon);
                    }
                    else if (health.ToString() == "null")
                    {
                        CheckHealth(drakes, type, health, dragon);
                    }
                    else if (armor.ToString() == "null")
                    {
                        CheckArmor(drakes, type, armor, dragon);
                    }

                    if (dumbList.Any(x => x.Name == name))
                    {
                        dragon.Name = name;
                        dragon.Damage = dmg;
                        dragon.Health = health;
                        dragon.Armor = armor;
                    }
                    else
                    {
                        drakes[type].Add(dragon);
                        dumbList.Add(dragon);

                        average[type].DmgAvg.Add(dmg);
                        average[type].HealthAvg.Add(health);
                        average[type].ArmorAvg.Add(armor);
                    }
                }

                else
                {
                    if (dmg.ToString() == "null")
                    {
                        CheckDmg(drakes, type, dmg, dragon);
                    }
                    else if (health.ToString() == "null")
                    {
                        CheckHealth(drakes, type, health, dragon);
                    }
                    else if (armor.ToString() == "null")
                    {
                        CheckArmor(drakes, type, armor, dragon);
                    }
                    else
                    {
                        drakes.Add(type, new List<Dragons>());
                        drakes[type].Add(dragon);
                        dumbList.Add(dragon);
                        average.Add(type, new DragonsAverage(new List<int>(dmg),
                            new List<int>(health), new List<int>(armor)));
                    }

                }
            }

            foreach (var item in drakes)
            {
                Console.WriteLine($"{item.Key}::({item.Value.Average(x => x.Damage):f2}/" +
                          $"{item.Value.Average(x => x.Health):f2}" +
                          $"/{item.Value.Average(x => x.Armor):f2})");

                foreach (var kvp in item.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{kvp.Name} -> damage: {kvp.Damage}" +
                                      $", health: {kvp.Health}, armor: {kvp.Armor}");
                }
            }

        }
        private static void CheckDmg(Dictionary<string, List<Dragons>> drakes, string type
            , int dmg, Dragons dragon)
        {
            dragon.Damage = 45;
        }
        private static void CheckHealth(Dictionary<string, List<Dragons>> drakes, string type
            , int health, Dragons dragon)
        {
            dragon.Health = 250;
        }
        private static void CheckArmor(Dictionary<string, List<Dragons>> drakes, string type
            , int armor, Dragons dragon)
        {
            dragon.Armor = 10;
        }
    }
}
