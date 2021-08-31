using System;

namespace Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = 0;

            if (a >= b)
            {
                result = a - b;
                if (result > 0.000001)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }
            }
            else if (a <= b)
            {
                result = b - a;
                if (result > 0.000001)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }
            }
           
        }
    }
}
