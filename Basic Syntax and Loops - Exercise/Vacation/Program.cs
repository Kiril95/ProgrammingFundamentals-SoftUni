using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();

            double sum = 0;

            if (group == "Students")
            {
                if (day == "Friday")
                {
                    sum = 8.45;
                }
                else if (day == "Saturday")
                {
                    sum = 9.80;
                }
                else if (day == "Sunday")
                {
                    sum = 10.46;
                }
                
                if (people >= 30)
                {
                    sum *= 0.85;
                }
                sum *= people;
            }
            else if (group == "Business")
            {
                if (day == "Friday")
                {
                    sum = 10.90;
                }
                else if (day == "Saturday")
                {
                    sum = 15.60;
                }
                else if (day == "Sunday")
                {
                    sum = 16;
                }
                
                if (people >= 100)
                {
                    people -= 10;
                }
                sum *= people;
            }
            else if (group == "Regular")
            {
                if (day == "Friday")
                {
                    sum = 15;
                }
                else if (day == "Saturday")
                {
                    sum = 20;
                }
                else if (day == "Sunday")
                {
                    sum = 22.50;
                }

                if (people >= 10 && people <= 20)
                {
                    sum *= 0.95;
                }
                sum *= people;

            }
            Console.WriteLine($"Total price: {sum:f2}");

        }
    }
}
