using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            foreach (var item in array1)
            {
                if (item % 2 == 0)
                {
                    sumEven += item;
                }
                else
                {
                    sumOdd += item;
                }
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
