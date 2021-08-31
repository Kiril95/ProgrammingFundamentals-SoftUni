using System;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp1 = int.Parse(Console.ReadLine());
            int emp2 = int.Parse(Console.ReadLine());
            int emp3 = int.Parse(Console.ReadLine());
            int clients = int.Parse(Console.ReadLine());
            int hours = 0;
            int total = emp1 + emp2 + emp3;

            while (clients > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }              
                clients -= total;

            }
            Console.WriteLine($"Time needed: {hours}h.");

        }
    }
}
