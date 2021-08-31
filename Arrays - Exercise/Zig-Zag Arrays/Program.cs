using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                 int[] current = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                if (i % 2 == 0)
                {
                    array1[i] = current[0];
                    array2[i] = current[1];
                }
                else
                {
                    array2[i] = current[0];
                    array1[i] = current[1];
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(' ', array1));
            Console.WriteLine(string.Join(' ', array2));

        }
    }
}
