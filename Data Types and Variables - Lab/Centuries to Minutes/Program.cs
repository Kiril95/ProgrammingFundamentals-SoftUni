using System;

namespace Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            double years = input * 100;
            double days = Math.Truncate(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;

            Console.WriteLine($"{input} centuries = {years} years = {days} days " +
                $"= {hours} hours = {minutes} minutes");

        }
    }
}
