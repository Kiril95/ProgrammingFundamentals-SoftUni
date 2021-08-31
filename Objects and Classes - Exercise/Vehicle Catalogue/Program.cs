using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Vehicle_Catalogue
{
    class Car
    {
        public Car(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public Truck(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog           // Когато правим клас, в който влизат други класове трябва да е така 
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Catalog register = new Catalog();
            string command = Console.ReadLine();
            //List<Car> cars = new List<Car>();  // Или просто да направим тук два класа, а не клас в клас
            //List<Truck> trucks = new List<Truck>();

            while (command != "End")
            {
                List<string> line = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string type = line[0];
                string model = line[1];
                string color = line[2];
                int horseP = int.Parse(line[3]);
                                           
                if (type == "car")
                {
                    Car automobiles = new Car(type, model, color, horseP);
                    register.Cars.Add(automobiles);
                }
                else if (type == "truck")
                {
                    Truck lorries = new Truck(type, model, color, horseP);
                    register.Trucks.Add(lorries);
                }

                command = Console.ReadLine();
            }
            
            while (true)
            {
                string final = Console.ReadLine();
                if (final == "Close the Catalogue")
                {
                    break;
                }

                for (int i = 0; i < register.Cars.Count; i++)
                {
                    if (register.Cars[i].Model.Contains(final))
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {register.Cars[i].Model}");
                        Console.WriteLine($"Color: {register.Cars[i].Color}");
                        Console.WriteLine($"Horsepower: {register.Cars[i].HorsePower}");
                    }
                }

                for (int i = 0; i < register.Trucks.Count; i++)
                {
                    if (register.Trucks[i].Model.Contains(final))
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {register.Trucks[i].Model}");
                        Console.WriteLine($"Color: {register.Trucks[i].Color}");
                        Console.WriteLine($"Horsepower: {register.Trucks[i].HorsePower}");
                    }
                }
                
                //final = Console.ReadLine();
            }

            double horseCar = 0;
            double horseTruck = 0;
            foreach (Car item in register.Cars)
            {
                horseCar += item.HorsePower;
            }

            foreach (Truck item in register.Trucks)
            {
                horseTruck += item.HorsePower;
            }

            double avgCarsHorse = horseCar / register.Cars.Count;
            double avgTrucksHorse = horseTruck / register.Trucks.Count;

            if (register.Cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {avgCarsHorse:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (register.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {avgTrucksHorse:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        
        }
    }
}
