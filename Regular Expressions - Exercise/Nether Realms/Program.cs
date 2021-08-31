using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    public class Demon
    {
        public Demon(string currentD, double health, double damage)
        {
            CurrentD = currentD;
            Health = health;     // Конструкторче
            Damage = damage;
        }
        public string CurrentD { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            SortedDictionary<string, Dictionary<double, double>> demons = new SortedDictionary<string, Dictionary<double, double>>();
            //List<Demon> army = new List<Demon>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentD = input[i];

                MatchCollection demonHealth = Regex.Matches(currentD, @"([^\d+\-.*\/]+)");
                MatchCollection demonDmg = Regex.Matches(currentD, @"([-\d]+\.?[\d]*)");
                MatchCollection symbols = Regex.Matches(currentD, @"([*\/])");

                string convertHealth = string.Join("", demonHealth.Select(x => x.ToString()));
                double health = convertHealth.Sum(x => (char)x);

                string[] convertDmg = demonDmg
                        .OfType<Match>()
                        .Select(x => (x.Value))
                        .ToArray();
                double damage = GetDmg(convertDmg, symbols); //Правим си метода в променлива

                //Demon armyOfDemons = new Demon(currentD, health, damage);
                //army.Add(armyOfDemons);
                
                if (!demons.ContainsKey(currentD))
                {
                    demons.Add(currentD, new Dictionary<double, double> { { health, damage } });
                }
                
            }
            foreach (var item in demons)
            {
                Console.Write(item.Key);
                foreach (var kvp in item.Value)
                {
                    Console.WriteLine($" - {kvp.Key} health, {kvp.Value:f2} damage");
                }
            }

            //Console.WriteLine($"{item.CurrentD} with ID: {item.Health} is {item.Damage} years old.");
        }

        public static double GetDmg(string[] convertDmg, MatchCollection symbols)
        {
            double damage = 0;
            foreach (var item in convertDmg)
            {
                damage += double.Parse(item);
            }
            
            foreach (Match item in symbols)
            {
                //string conv = item.ToString();
                if (item.ToString() == "*")
                {
                    damage *= 2;
                }
                else if (item.ToString() == "/")
                {
                    damage /= 2;
                }
            }
            return damage;

        }
    }
}
