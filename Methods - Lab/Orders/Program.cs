using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            Final(product, quantity);

            static void Final(string product, double quantity)
            {
                if (product == "coffee")
                {
                    quantity *= 1.50;
                }
                else if (product == "water")
                {
                    quantity *= 1.00;
                }
                else if (product == "snacks")
                {
                    quantity *= 2.00;
                }
                else if (product == "coke")
                {
                    quantity *= 1.40;
                }

                Console.WriteLine($"{quantity:f2}");
            }
        }
    }
}
