using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> langWithPass = new Dictionary<string, string>();
            Dictionary<string, int> usersWithPoints = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, int>> main = 
                                    new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();

            while (command != "end of contests")
            {
                string[] operations = command.Split(":");
                string language = operations[0];
                string pass = operations[1];

                if (!langWithPass.ContainsKey(language))
                {
                    langWithPass.Add(language, pass);
                }
                command = Console.ReadLine();

            }
            string command2 = Console.ReadLine();

            while (command2 != "end of submissions")
            {
                string[] operations2 = command2.Split("=>");
                string language = operations2[0];
                string pass = operations2[1];
                string user = operations2[2];
                int points = int.Parse(operations2[3]);

                if (langWithPass.ContainsKey(language)
                   && langWithPass[language] == pass)
                {
                    if (!main.ContainsKey(user))
                    {
                        main.Add(user, new Dictionary<string, int> {{ language, points }} );
                        usersWithPoints.Add(user, points);
                    }
                       //Мain[user]означава, че влизаме във вътрешния Речник и търсим дали има такъв Ключ
                    if (main[user].ContainsKey(language))
                    {
                        // Проверявам дали на този индекс(user) и на тази стойност(language)
                        // точките са по малко от текущите
                        if (main[user][language] < points)
                        {
                            main[user][language] = points;
                        }
                    }
                    else
                    {
                        usersWithPoints[user] += points;
                        main[user].Add(language, points);
                    }                 
                }             
               command2 = Console.ReadLine();

            }
            // var max = main.Values.Max();
            int best = 0;
            string bestUser = string.Empty;
            foreach (var item in main.Values)
            {
                if (item.Values.Sum() > best) // Влиза в стойностите, смята и намира най-добрата сума
                {
                    best = item.Values.Sum();
                    bestUser = main.Keys.Max(); //Открива Ключа на въпросната най-добра сума.
                }
            }

            Console.WriteLine($"Best candidate is {bestUser} with total {best} points.");
            Console.WriteLine("Ranking:");

            foreach (var item in main.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var kvp in item.Value.OrderByDescending(x => x.Value))
                {
                    //Достъпвам другата KVP двойка във вътрешния Речник
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
            

        }
    }
}
