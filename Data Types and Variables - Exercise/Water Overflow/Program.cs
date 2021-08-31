using System;

namespace Water_Overflow
{
    class Program
    {

        static void Main(string[] args)
        {
            short lines = short.Parse(Console.ReadLine());
            int tank = 255;
            int total = 0;

            for (int i = 0; i < lines; i++)
            {
                int liters = int.Parse(Console.ReadLine());            
                total += liters;
                if (total > tank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    total -= liters;
                    continue;
                }
            }
            Console.WriteLine(total);

        }
    }
}
