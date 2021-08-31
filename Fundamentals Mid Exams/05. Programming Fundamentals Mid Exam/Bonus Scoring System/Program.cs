using System;

namespace Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = int.Parse(Console.ReadLine());
            double lectures = int.Parse(Console.ReadLine());
            double bonus = int.Parse(Console.ReadLine());
            double max = 0;
            double lectureSave = 0;

            for (int i = 0; i < students; i++)
            {
                double attend = double.Parse(Console.ReadLine());
                double result = (attend / lectures) * (5 + bonus);

                if (result > max)
                {
                    max = result;
                    lectureSave = attend;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Round(max)}.");
            Console.WriteLine($"The student has attended {lectureSave} lectures.");

        }
    }
}
