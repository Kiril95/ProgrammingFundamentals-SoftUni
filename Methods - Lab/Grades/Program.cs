using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(Grades(num));

        }

        static string Grades(double num)
        {
            string grade = "  ";

            if (num >= 2.00 && num <= 2.99)
            {
                grade = "Fail";
            }
            else if (num >= 3.00 && num <= 3.49)
            {
                grade = "Poor";
            }
            else if (num >= 3.50 && num <= 4.49)
            {
                grade = "Good";
            }
            else if (num >= 4.50 && num <= 5.49)
            {
                grade = "Very good";
            }
            else if (num >= 5.50 && num <= 6.00)
            {
                grade = "Excellent";
            }

            return $"{grade}";

        }
    }
}
