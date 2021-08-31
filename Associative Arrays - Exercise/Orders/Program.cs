using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> result = new Dictionary<string, List<double>>();
                      
            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] operations = command.Split(" ");
                string product = operations[0];
                double price = double.Parse(operations[1]);
                double quantity = double.Parse(operations[2]);

                if (!result.ContainsKey(product))
                {
                    //Ако го няма Ключът директно записвам всичките ми подадени стойностти
                    result.Add(product, new List<double> { price, quantity });
                }
                else
                {
                    //Така се достъпват елементите на съответния индекс във Value частта
                    result[product][0] = price;
                    result[product][1] += quantity;
                }                     
                command = Console.ReadLine();
            }

            foreach (var item in result)
            {
                double final = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {final:f2}");
            }
        }
    }
}
