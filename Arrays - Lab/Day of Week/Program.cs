using System;
using System.Linq;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] days = {"Monday", "Tuesday",
                "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            //int test = Convert.ToInt32(days);
            
            if (day > 0 && day <= days.Length)
            {
                day -= 1;
                Console.WriteLine(days[day]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

            int day = int.Parse(Console.ReadLine());
            string[] days = {"Monday", "Tuesday",
                "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            foreach (var item in days)
            {
                if (day >= 1 && day <= days.Length)
                {
                    Console.WriteLine(days[day-1]);
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid day!");
                    return;
                }

            }
        }
    }
}
