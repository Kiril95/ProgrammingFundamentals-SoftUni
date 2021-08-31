using System;
using System.Collections.Generic;
using System.Linq;

namespace Need_for_Speed_III
{
    class Info
    {
        public Info(int miles, int fuel)
        {
            Miles = miles;
            Fuel = fuel;                //Конструкторчее
        }
        public int Miles { get; set; }
        public int Fuel { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Info> game = new Dictionary<string, Info>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string car = line[0];
                int miles = int.Parse(line[1]);
                int fuel = int.Parse(line[2]);

                game.Add(car, new Info(miles, fuel));
            }
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] operations = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string car = operations[1];

                if (operations[0] == "Drive")
                {
                    int distance = int.Parse(operations[2]);
                    int fuel = int.Parse(operations[3]);

                    if (game[car].Fuel >= fuel)
                    {
                        game[car].Fuel -= fuel;
                        game[car].Miles += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (game[car].Miles >= 100000)
                        {
                            game.Remove(car);
                            Console.WriteLine($"Time to sell the {car}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (operations[0] == "Refuel")
                {
                    int amount = int.Parse(operations[2]);

                    if (game[car].Fuel + amount > 75)
                    {                       
                        Console.WriteLine($"{car} refueled with {75 - game[car].Fuel} liters");
                        game[car].Fuel = 75;
                    }
                    else
                    {
                        game[car].Fuel += amount;
                        Console.WriteLine($"{car} refueled with {amount} liters");
                    }

                }
                else if (operations[0] == "Revert")
                {
                    int km = int.Parse(operations[2]);

                    //int decreased = game[car].Miles - km;
                    game[car].Miles -= km;

                    if (game[car].Miles < 10000)
                    { 
                        game[car].Miles = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {km} kilometers");                      
                    }

                }
                command = Console.ReadLine();
            }
            game = game
                .OrderByDescending(x => x.Value.Miles)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in game)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Miles} kms, Fuel in the tank: {item.Value.Fuel} lt.");

            }

        }
    }
}
