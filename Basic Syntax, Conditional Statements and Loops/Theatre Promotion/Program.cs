using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());

            double sum = 0;

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            if (name == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    sum = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    sum = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    sum = 12;
                }
            }
            else if (name == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    sum = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    sum = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    sum = 15;
                }
            }
            else if (name == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    sum = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    sum = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    sum = 10;
                }
            }
            Console.WriteLine($"{sum}$");
        }
    }
}
