using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            var date = new DateTime(2021,02,05, hours, minutes, 00);
            date = date.AddMinutes(30);
            if (date.Minute >= 1 && date.Minute <= 9)
            {
                Console.WriteLine(date.Hour + ":0" + date.Minute);
            }
            else
            {
                Console.WriteLine(date.Hour + ":" + date.Minute);
            }
        }
    }
}
