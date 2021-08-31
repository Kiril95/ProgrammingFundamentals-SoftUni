using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine(); 
            //string products = "";
            decimal sum = 0;
            while (command != "Start")
            {
                decimal coins = decimal.Parse(command);
                if (coins == 0.1m)
                {
                    sum += coins;
                }
                else if (coins == 0.2m)
                {
                    sum += coins;
                }
                else if (coins == 0.5m)
                {
                    sum += coins;
                }
                else if (coins == 1.0m)
                {
                    sum += coins;
                }
                else if (coins == 2.0m)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                command = Console.ReadLine();
            }

            string products = " ";
            while (products != "End")
            {
                products = Console.ReadLine();
                if (products == "End")
                {
                    break;
                }

                if (products == "Nuts")
                {
                    if (sum < 2.0m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    sum -= 2.0m;
                    Console.WriteLine($"Purchased {products.ToLower()}");

                }
                else if (products == "Water")
                {
                    if (sum < 0.7m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    sum -= 0.7m;
                    Console.WriteLine($"Purchased {products.ToLower()}");

                }
                else if (products == "Crisps")
                {
                    if (sum < 1.5m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    sum -= 1.5m;
                    Console.WriteLine($"Purchased {products.ToLower()}");

                }
                else if (products == "Soda")
                {
                    if (sum < 0.8m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    sum -= 0.8m;
                    Console.WriteLine($"Purchased {products.ToLower()}");

                }
                else if (products == "Coke")
                {
                    if (sum < 1.0m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    sum -= 1.0m;
                    Console.WriteLine($"Purchased {products.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {sum:f2}");



            //double coins = 0;
            //double sum = 0;
            //string command = Console.ReadLine();
            //
            //double[] prices = new double[5] { 2.0, 0.7, 1.5, 0.8, 1.0 };
            //double[] coinMachine = new double[5] { 0.1, 0.2, 0.5, 1.0, 2.0 };
            //string[] names = new string[5] { "Nuts", "Water", "Crisps", "Soda", "Coke" };
            //double sample = coinMachine.Length;
            //
            //for (int i = 0; i < prices.Length; i++)
            //{
            //    while (command != "Start")
            //    {
            //        
            //        coins = double.Parse(command);
            //
            //        if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1.00 || coins == 2.00)
            //        {
            //            sum += coins;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Cannot accept {coins}");
            //        }
            //        command = Console.ReadLine();
            //    }
            //    while (command != "End")
            //    {
            //        command = Console.ReadLine();
            //
            //        if (sum < coins)
            //        {
            //            Console.WriteLine("Sorry, not enough money");
            //        }
            //
            //        if (command == names[0])
            //        {
            //            sum -= 2.0;
            //        }
            //        else if (command == "Water")
            //        {
            //            sum -= 0.7;
            //        }
            //        else if (command == "Crisps")
            //        ////{
            //            sum -= 1.5;
            //        }
            //        else if (command == "Soda")
            //        {
            //            sum -= 0.8;
            //        }
            //        else if (command == "Coke")
            //        {
            //            sum -= 1.0;
            //        }
            //        else 
            //        {
            //            Console.WriteLine("Invalid product");
            //        }
            //    }
            //}
            //Console.WriteLine($"Change: {sum}");

        }
    }
}
