using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> result = new SortedDictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] operations = command.Split(" -> ");
                string name = operations[0];
                string badge = operations[1];

                if (!result.ContainsKey(name))
                {
                    result.Add(name, new List<string> { badge });
                }
                else
                {
                    //Проверка дали дадена стойност присъства на дадения Ключ
                    bool containsBadge = result.Any(x => x.Value.Contains(badge));

                    if (!containsBadge)
                    {
                        result[name].Add(badge);
                    }                 
                }
                command = Console.ReadLine();

            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}");

                //Когато KVP двойките трябва да ги отпечатваме на нов ред, следва да
                //направим вложен foreach и обхождаме всичко във Value частта, 
                //като използваме променливата от първия цикъл

                //var checkBadge = result.Values.Distinct().ToList();
                //Провеярва за повтарящи се стойонсти и ги премахва
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"-- {value}");
                }

            }

        }
    }
}
