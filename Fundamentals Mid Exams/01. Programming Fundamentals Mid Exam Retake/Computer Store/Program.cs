using System;
using System.Data;

namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string save = " ";
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "special")
                {
                    save = "special";
                    break;
                }
                if (command == "regular")
                {
                    //save = "regular";
                    break;
                }

                double parts = double.Parse(command);
                if (parts <= 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    total += parts;
                }

            }

            double final = 0;
            double taxes = 0;
            if (total <= 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else
            {
                taxes = total * 0.20;
                final = total + taxes;
            }
            if (save == "special")
            {
                final *= 0.90;
            }

            Console.WriteLine($"Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {total:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {final:f2}$");

        }
    }
}
