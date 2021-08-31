using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;                    // Конструкторче         
        }
        public string Name { get; set; }
        public double Price { get; set; }

        //public static implicit operator Item(string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
    class Box
    {
        public Box(string serialNum, string item, int itemQuantity, double pricePerBox, double finalPrice)
        {
            SerialNum = serialNum;
            Item = item;                    // Конструкторче
            ItemQuantity = itemQuantity;
            PricePerBox = pricePerBox;
            FinalPrice = finalPrice = itemQuantity * pricePerBox;
        }
        //public Box()
        //{
        //    Item = new Item();
        //}
        public string SerialNum { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PricePerBox { get; set; }
        public double FinalPrice { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Box> boxes = new List<Box>();
            //List<Item> items = new List<Item>();

            while (command != "end")
            {
                string[] operations = command.Split(" ").ToArray();

                string serial = operations[0];
                string item = operations[1];
                int quantity = int.Parse(operations[2]);
                double price = double.Parse(operations[3]);
                var finalPrice = 0;

                Box storage = new Box(serial, item, quantity, price, finalPrice);
                //Item storage2 = new Item(item, price);
                boxes.Add(storage);
                //items.Add(storage2);

                command = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(x => x.FinalPrice).ToList();
            foreach (Box sack in boxes)
            {
                Console.WriteLine($"{sack.SerialNum}\n" +
                    $"-- {sack.Item} - ${sack.PricePerBox:f2}: {sack.ItemQuantity}\n" +
                    $"-- ${sack.FinalPrice:f2}");
            }
        }
    }
}
