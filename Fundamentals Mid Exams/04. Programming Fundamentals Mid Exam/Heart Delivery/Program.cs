using System;
using System.Linq;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int current = 0;
            string command = Console.ReadLine();

            while (command != "Love!")
            {
                string[] operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int jump = int.Parse(operations[1]);

                current += jump;
                if (current >= houses.Length)
                {
                    current = 0;
                }

                if (houses[current] != 0)
                {
                    houses[current] -= 2;

                    if (houses [current] == 0)
                    {
                        Console.WriteLine($"Place {current} has Valentine's day.");
                    }                  
                }

                else
                {
                    Console.WriteLine($"Place {current} already had Valentine's day.");
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"Cupid's last position was {current}.");

            int count = 0;
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i] > 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }
    
           //foreach (int item in houses.Where(x => x > 0))
           //{
           //    if (houses[item] > 0)
           //    {
           //        count++;
           //    }
           //}
           //if (count == 0)
           //{
           //    Console.WriteLine("Mission was successful.");
           //}
           //else
           //{
           //    Console.WriteLine($"Cupid has failed {count} places.");
           //}

        }
    }
}
