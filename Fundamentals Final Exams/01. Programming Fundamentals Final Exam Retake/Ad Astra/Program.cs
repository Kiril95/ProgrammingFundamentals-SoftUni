using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            double total = 0;

            Regex pattern = new Regex(@"([#|\|]?)(?<name>[A-Za-z\s]+)\1(?<exp>(\d{2})\/(\d{2})\/(\d{2}))\1(?<cal>[\d]+)\1");
            MatchCollection matches = pattern.Matches(line);

            int sum = matches.Select(x => int.Parse(x.Groups["cal"].Value)).Sum();            
            Console.WriteLine($"You have food to last you for: {sum / 2000} days!");

            foreach (Match item in matches)
            {
                string product = item.Groups["name"].Value;
                string expire = item.Groups["exp"].Value;
                string calories = item.Groups["cal"].Value;

                Console.WriteLine($"Item: {product}, Best before: {expire}, Nutrition: {calories}");
            }
        }
    }
}
