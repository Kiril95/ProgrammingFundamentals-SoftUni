using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            double yield = double.Parse(Console.ReadLine());
            double total = 0;
            int days = 0;

            if (yield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(total);
                return;
            }

            while (yield >= 100)
            {
                days++;
                total += yield;                                         
                total -= 26;
                yield -= 10;

                if (yield < 100)
                {
                    total -= 26;
                    Console.WriteLine(days);
                    Console.WriteLine(total);
                }
            }
        }
    }
}
