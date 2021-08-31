using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 0; i < orders; i++)
            {
                double price = double.Parse(Console.ReadLine());
                double days = double.Parse(Console.ReadLine());
                double capsules = double.Parse(Console.ReadLine());

                double result = (days * capsules) * price;
                total += result;
                Console.WriteLine($"The price for the coffee is: ${result:f2}");

            }
            Console.WriteLine($"Total: ${total:f2}");


        }
    }
}
