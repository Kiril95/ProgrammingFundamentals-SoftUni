using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int fromLeft = array1.Length / 4;

            int[] result = new int[fromLeft * 2];

            for (int i = 0; i < fromLeft; i++)
            {
                result[i] = array1[i + fromLeft] + array1[fromLeft - 1 - i];

                result[i + fromLeft] = array1[i + 2 * fromLeft] + array1[array1.Length - 1 - i];
            }

            Console.WriteLine(String.Join(' ', result));
        }
    }
}
