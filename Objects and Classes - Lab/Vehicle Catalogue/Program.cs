using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Car
    {
        public Car(string type, string brand, string model, int horsePower)
        {
            Type = type;
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }         
        public int HorsePower { get; set; }     
    }
    class Truck
    {
        public Truck(string type, string brand, string model, int weight)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
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
            string command = Console.ReadLine();

            Catalog fullCatalog = new Catalog();

            while (command != "end")
            {
                string[] operations = command.Split("/").ToArray();

                string type = operations[0];
                string brand = operations[1];
                string model = operations[2];
                int weightOrHorsePower = int.Parse(operations[3]);

                Car automobiles = new Car(type,  brand,  model, weightOrHorsePower);
                Truck lorries = new Truck(type,  brand,  model, weightOrHorsePower);
                
                if (type == "Car")
                {
                    fullCatalog.Cars.Add(automobiles);
                }
                else if (type == "Truck")
                {
                    fullCatalog.Trucks.Add(lorries);
                }
                           
                command = Console.ReadLine();
            }

            if (fullCatalog.Cars.Capacity > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car cars in fullCatalog.Cars.OrderBy(x => x.Brand))
                {

                    Console.WriteLine($"{cars.Brand}: {cars.Model} - {cars.HorsePower}hp");
                }
            }

            if (fullCatalog.Trucks.Capacity > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck trucks in fullCatalog.Trucks.OrderBy(x => x.Brand))
                {

                    Console.WriteLine($"{trucks.Brand}: {trucks.Model} - {trucks.Weight}kg");
                }
            }                 
        }
    }
}
