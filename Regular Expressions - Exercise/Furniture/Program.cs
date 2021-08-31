using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double total = 0;
            List<string> store = new List<string>();
            Regex pattern = new Regex(@">>(?<furniture>[\w]+)<<(?<price>[\d.]+)!(?<quant>[\d]+\b)");

            while (command != "Purchase")
            {
                Match matched = pattern.Match(command);
                if (matched.Success)
                {
                    string furniture = matched.Groups["furniture"].Value;
                    double price = double.Parse(matched.Groups["price"].Value);
                    double quantity = double.Parse(matched.Groups["quant"].Value);

                    total += price * quantity;
                    store.Add(furniture.ToString());
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in store)
            {           
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
