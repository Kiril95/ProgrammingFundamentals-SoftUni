using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Operations(first, sign, second)}");
        }

        static double Operations(int first, string sign, int second)
        {
            double result = 0;

            if (sign == "/")
            {
                result = first / second;
            }
            else if (sign == "*")
            {
                result = first * second;
            }
            else if (sign == "+")
            {
                result = first + second;
            }
            else if (sign == "-")
            {
                result = first - second;
            }

            return result;
        } 
    }
}
