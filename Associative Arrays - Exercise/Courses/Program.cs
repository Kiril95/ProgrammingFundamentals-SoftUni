using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] operations = command.Split(" : ");
                string course = operations[0];
                string name = operations[1];

                if (!result.ContainsKey(course))
                {
                    result.Add(course, new List<string> { name });
                }
                else
                {
                    result[course].Add(name);
                }
                command = Console.ReadLine();
            }
            //var ordered = result
            //.OrderByDescending(x => x.Key.Count())          
            //.ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in result.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()}");

                //item.Value.Sort();
                //Когато KVP двойките трябва да ги отпечатваме на нов ред, следва да
                //направим вложен foreach и обхождаме всичко във Value частта, 
                //като използваме променливата от първия цикъл

                foreach (var value in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {value}");
                }
                
            }

        }
    }
}
