using System;
using System.Numerics;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < num; i++)
            {
                decimal current = decimal.Parse(Console.ReadLine());
                sum += current;
            }
            Console.WriteLine(sum);

        }
    }
}
