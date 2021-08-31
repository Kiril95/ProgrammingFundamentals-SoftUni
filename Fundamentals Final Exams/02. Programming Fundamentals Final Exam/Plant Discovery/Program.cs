using System;
using System.Collections.Generic;
using System.Linq;

namespace Plant_Discovery
{
    class Herba
    {
        public Herba(double rarity, List<double> rating)
        {
            Rarity = rarity;
            Rating = rating;                //Конструкторчее
        }
        public double Rarity { get; set; }
        public List<double> Rating { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Dictionary<string, List<double>> storage = new Dictionary<string, List<double>>();
            Dictionary<string, Herba> herbalism = new Dictionary<string, Herba>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = line[0];
                double rare = double.Parse(line[1]);

                if (herbalism.ContainsKey(plant))
                {
                    herbalism[plant].Rarity = rare;
                }
                else
                {
                    //storage.Add(plant, new List<double>());
                    herbalism.Add(plant, new Herba(rare, new List<double>()));
                }
            }
            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] operations = command
                    .Split(new char[] { ':', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string plant = operations[1].Trim();

                if (!herbalism.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                }
                else
                {
                    if (operations[0] == "Rate")
                    {
                        double rate = double.Parse(operations[2]);

                        if (herbalism.ContainsKey(plant))
                        {
                            //storage[plant].Add(rate);
                            herbalism[plant].Rating.Add(rate);
                        }
                    }
                    else if (operations[0] == "Update")
                    {
                        double rare = double.Parse(operations[2]);

                        if (herbalism.ContainsKey(plant))
                        {
                            herbalism[plant].Rarity = rare;
                        }
                    }
                    else if (operations[0] == "Reset")
                    {
                        if (herbalism.ContainsKey(plant))
                        {
                            //storage[plant] = new List<double>();
                            herbalism[plant].Rating.Clear();
                            //herbalism[plant].Rating.Add(0.00);
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in herbalism)
            {
                if (item.Value.Rating.Count() > 0)
                {
                    double avg = item.Value.Rating.Average();
                    item.Value.Rating.Clear();
                    item.Value.Rating.Add(avg);
                }
            }           
            herbalism = herbalism
                .OrderByDescending(x => x.Value.Rarity)
                .ThenByDescending(x => x.Value.Rating.Sum())
                .ToDictionary(x => x.Key, x => x.Value);

            double average = 0;
            if (herbalism.Count > 0)
            {
                foreach (var item in herbalism)
                {
                   if (item.Value.Rating.Count == 0)
                   {
                        average = 0;
                   }
                   else
                   {
                        average = item.Value.Rating.Sum();
                   }
                   Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {average:f2}");
                }
            }
            
           // double ratingAverage = 0;
           // if (herbalism.Count > 0)
           // {
           //     foreach (var plant in herbalism.OrderByDescending(x => x.Value.Rarity).ThenByDescending(x => x.Value.Rating.Sum()))
           //     {
           //         if (plant.Value.Rating.Count == 0)
           //         {
           //             ratingAverage = 0;
           //         }
           //         else
           //         {
           //             ratingAverage = plant.Value.Rating.Sum();
           //         }
           //         Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {ratingAverage:f2}");
           //     }
           // }

        }
    }
}
