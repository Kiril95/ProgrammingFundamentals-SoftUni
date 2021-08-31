using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> planets = new Dictionary<string, List<string>>()
            {
                {"A", new List<string>()},
                {"D", new List<string>()}
            };

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection getCount = Regex.Matches(input, @"([STARstar])");
                int count = getCount.ToArray().Count(); //Броя колко елемента има в Мачнато-то

                //Хваща всеки един ЧАР в стринга и изважда от него дължината на Мачнато-то, 
                //образувайки новия стринг, с който трябва да работя
                string decrypted = new string(input.Select(x => (char)(x - count)).ToArray());

                Regex pattern = new Regex(@"@(?<planet>[A-Z][a-z]+)([^@\-!:>])*:(?<population>[\d]+)([^@\-!:>])*!(?<attack>[AD]?)!([^@\-!:>])*->(?<soldiers>[\d]+)");
                Match matched = pattern.Match(decrypted);           //PQ @Alderaa1:30000!A!->20000

                if (matched.Success)
                {
                    string planet = matched.Groups["planet"].Value;
                    string attack = matched.Groups["attack"].Value;

                    if (attack == "A")
                    {
                        PlanetsOperation(attack, planet, planets);

                    }
                    else if (attack == "D")
                    {
                        PlanetsOperation(attack, planet, planets);
                    }

                }                      
            }

            //Така сортираме стойностите в даден Лист
            planets = planets
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => (List<string>)x.Value.OrderBy(x => x).ToList());

            foreach (var item in planets)
            {
                if (item.Key == "A")
                {
                    Console.WriteLine($"Attacked planets: {item.Value.Count}");
                }
                else
                {
                    Console.WriteLine($"Destroyed planets: {item.Value.Count}");
                }       
                
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($"-> {kvp}");
                }
            }
        }

        private static void PlanetsOperation(string attack, string planet,
                                            Dictionary<string, List<string>> planets)
        {          
           if (planets.ContainsKey(attack))
           {
               planets[attack].Add(planet);
           }
           //else
           //{
           //    planets.Add(attack, new List<string> { planet });
           //}
        }      
    }
}
