using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> main = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            main.Add("motes", 0);
            main.Add("shards", 0);
            main.Add("fragments", 0);
            
            while (true)
            {
                if (main["shards"] >= 250 || main["motes"] >= 250 || main["fragments"] >= 250)
                {
                    break;
                }

                List<string> sequence = Console.ReadLine()
                .Split(" ")
                .ToList();

                for (int i = 0; i < sequence.Count; i += 2)
                {
                    //Цикъл със стъпка, за да хващам по два елмента от Листа
                    //Трябва да третирам инпута като няколко реда Лист, вместо един цял, за това
                    //с два цикъла и като обходя първия Лист да мина на следващия ред инпут
                    int num = int.Parse(sequence[i]);
                    string material = sequence[i + 1].ToLower();

                    if (main["shards"] >= 250 || main["motes"] >= 250 || main["fragments"] >= 250)
                    {
                        break;
                    }

                    if (material == "shards" || material == "motes" || material == "fragments")
                    {
                        if (!main.ContainsKey(material))
                        {
                            main.Add(material, num);
                        }
                        else
                        {
                            main[material] += num;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, num);
                        }
                        else
                        {
                            junk[material] += num;
                        }
                    }                   
                }
                
            }
            if (main["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                main["shards"] -= 250;
            }
            else if (main["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                main["fragments"] -= 250;
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");
                main["motes"] -= 250;
            }

            foreach (var item in main.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
