using System;
using System.Transactions;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double totalSpent = 0;
            double price = 0;
            //double outFall  = 39.99;
            //double csOG = 15.99;
            //double zplinterZell = 19.99;
            //double honored2 = 59.99;
            //double roverWatch = 29.99;
            //double roverWatchOriginsEdition = 39.99;

            while (game != "Game Time")
            {            
                if (game == "OutFall 4")
                {
                    price = 39.99;
                }
                else if (game == "CS: OG")
                {
                    price = 15.99;
                }
                else if (game == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (game == "Honored 2")
                {
                    price = 59.99;
                }
                else if (game == "RoverWatch")
                {
                    price = 29.99;
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    game = Console.ReadLine();
                    continue;
                }

                if (price <= balance)
                {
                    Console.WriteLine($"Bought {game}");
                    totalSpent += price;
                    balance -= price;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                game = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent}. Remaining: ${balance:f2}");
        }
    }
}
