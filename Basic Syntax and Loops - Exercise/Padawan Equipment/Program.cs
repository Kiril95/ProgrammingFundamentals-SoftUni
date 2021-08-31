using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());
            double sum = 0;
            double newBelts = 0;

            if (studCount >= 6)
            {
                newBelts = studCount / 6;
                newBelts = beltsPrice * (studCount - newBelts);
                sum = saberPrice * (Math.Ceiling(studCount * 1.10))
                    + (robesPrice * studCount) + newBelts; 
            }
            else
            {
                sum = saberPrice * (Math.Ceiling(studCount * 1.10))
                    + (robesPrice * studCount) + (beltsPrice * studCount);
            }

            if (budget >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {sum - budget:f2}lv more.");
            }       

        }
    }
}
