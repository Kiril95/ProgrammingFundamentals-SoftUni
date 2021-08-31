using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array1 = Console.ReadLine()
            //                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //                .Select(int.Parse)
            //                .ToArray();
            //int sum = 0;
            //
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (array1[i] % 2 == 0)
            //    {
            //        sum += array1[i];
            //    }
            //}
            //Console.WriteLine(sum);


            int[] array1 = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int sum = 0;

            foreach (var item in array1)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
