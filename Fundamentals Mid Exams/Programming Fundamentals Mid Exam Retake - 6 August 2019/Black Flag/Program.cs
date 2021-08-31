using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double plunderPerDay = double.Parse(Console.ReadLine());
            double targetPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += plunderPerDay;

                if (i % 3 == 0)
                {
                    double bonus = plunderPerDay / 2;
                    totalPlunder += bonus;
                }
             
                if (i % 5 == 0)
                {
                    totalPlunder *= 0.70;                 
                }             

            }
            if (totalPlunder >= targetPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = (totalPlunder / targetPlunder) * 100;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }

        }
    }
}
