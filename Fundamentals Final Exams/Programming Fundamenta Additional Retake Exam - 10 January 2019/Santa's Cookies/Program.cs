using System;

namespace Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            
            int boxes = 0;

            for (int i = 0; i < batches; i++)
            {
                int flour = int.Parse(Console.ReadLine()) / 140;
                int sugar = int.Parse(Console.ReadLine()) / 20;
                int cocoa = int.Parse(Console.ReadLine()) / 10;

                if (flour <= 0 || sugar <= 0 || cocoa <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    int min = Math.Min(flour, Math.Min(sugar, cocoa)); // Min измежду 3 променливи
                    int total = (170 * min / 25) / 5;
                    boxes += total;

                    Console.WriteLine($"Boxes of cookies: {total}");
                }           
            }
            Console.WriteLine($"Total boxes: {boxes}");

        }
    }
}
