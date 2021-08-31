using System;
using System.Linq;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(GetMin(numbers));
        }

        static int GetMin(params int[] numbers)
        {
            return numbers.Min();
        }

    }
}
