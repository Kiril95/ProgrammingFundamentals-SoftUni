using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double POWA = double.Parse(Console.ReadLine()); // Pascal case... Wat ?

            Console.WriteLine(YouHaveNoPowerHere(num, POWA));

            static double YouHaveNoPowerHere(double num, double POWA)
            {
               return Math.Pow(num, POWA);
               
            }
        }
    }
}
