using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                   .Split(">", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToList();

            List<int> warShip = Console.ReadLine()
                   .Split(">", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToList();
            int health = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "Retire")
            {
                string[] operations = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string act = operations[0];

                if (act == "Fire")
                {
                    int idx = int.Parse(operations[1]);
                    int dmg = int.Parse(operations[2]);
                    if (idx >= 0 && idx < pirateShip.Count)
                    {
                        warShip[idx] -= dmg;

                        if (warShip[idx] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }

                }
                else if (act == "Defend")
                {
                    int start = int.Parse(operations[1]);
                    int end = int.Parse(operations[2]);
                    int dmg = int.Parse(operations[3]);
                    //List<int> newShip = new List<int>(pirateShip);

                    if (start >= 0 && start < pirateShip.Count
                       && end >= 0 && end < pirateShip.Count)
                    {
                        for (int i = start; i <= end; i++) 
                        {
                            //Директно започвам от индексите и ги пускам в Листа(1 до 5 например)
                            pirateShip[i] -= dmg;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }

                        //var range = pirateShip.GetRange(start, end + 1);
                        //for (int i = 0; i < range.Count; i++)
                        //{
                        //    range[i] -= dmg;
                        //}
                        //pirateShip.RemoveRange(start, end + 1);
                        //pirateShip.InsertRange(start, range);
                        ////var check = range.All(x => x <= 0);
                        //var check = pirateShip.Any(x => x <= 0);
                        //if (check)
                        //{
                        //    Console.WriteLine("You lost! The pirate ship has sunken.");
                        //    return;
                        //}
                    }

                }
                else if (act == "Repair")
                {
                    int idx = int.Parse(operations[1]);
                    int restore = int.Parse(operations[2]);

                    if (idx >= 0 && idx < pirateShip.Count)
                    {
                        var diff = health - pirateShip[idx];
                        
                        if (pirateShip[idx] + restore > health)
                        {
                            // Първо намирам разликата от максимума - елемента, след това проверявам
                            // дали не надвишава отредения максимум, след това просто добавям разликата
                            // pirateShip[idx] = health; // Директно записвам пълната кръв
                            pirateShip[idx] += diff;
                        }
                        else
                        {
                            pirateShip[idx] += restore;
                        }
                        
                    }
                }
                else if (act == "Status")
                {
                    int count = 0;
                    //List<int> perc = new List<int>();
                    for (int i = 0; i < pirateShip.Count; i++)
                    {                    
                        double prc = (double)pirateShip[i] / health * 100;                                              
                        if (prc < 20)
                        {
                            count++;
                        }                      
                    }              
                    Console.WriteLine($"{count} sections need repair.");

                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");

        }
    }
}
