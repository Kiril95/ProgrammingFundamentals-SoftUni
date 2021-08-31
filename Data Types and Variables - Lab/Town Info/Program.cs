using System;

namespace Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            long selqni = long.Parse(Console.ReadLine());
            int km = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {selqni} and area {km} square km.");
        }
    }
}
