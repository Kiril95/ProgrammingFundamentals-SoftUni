using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> result = new SortedDictionary<double, int>();

            foreach (var key in numbers)
            {
                if (result.ContainsKey(key))
                {
                    result[key]++;
                }
                else
                {
                    // Адд при Речници, очаква на първо място да се добави (ключът), а на второ стойността
                    result.Add(key, 1);
                    //result[key] = 1;
                }
            }
            
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
