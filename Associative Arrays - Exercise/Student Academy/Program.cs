using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> result = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!result.ContainsKey(name))
                {
                    result.Add(name, new List<double> { grade });
                }
                else
                {
                    result[name].Add(grade);
                }

            }
            // Със Селектора компресираме резулата от Списъка(double) на само едно число, което
            // ще е(Average) и след това няма нужда да имаме повтаряне на логика
            //var newResult = result
            //      .Select(x => new KeyValuePair<string, double>(x.Key, x.Value.Average()))
            //      .Where(x => x.Value >= 4.50)
            //      .OrderByDescending(x => x.Value)
            //      .ToDictionary(x => x.Key, x => x.Value);

            var newResult = result
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);
       
            foreach (var item in newResult)
            {
                var avg = item.Value.Average();
                Console.WriteLine($"{item.Key} -> {avg:f2}");
            }

        }
    }
}
