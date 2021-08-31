using System;
using System.Linq;
using System.Text;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array1 = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();
            //
            //for (int i = 1; i <= array1.Length; i++)
            //{
            //    for (int j = i; j < array1.Length; j++)
            //    {
            //        if (array1[i] >= array1[j] && array1.Length - 1 == j)
            //        {
            //            Console.Write(array1[i] + " ");
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //}

            int[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array1.Length; i++)
            {
                bool isBigger = true;

                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1[i] <= array1[j])
                    {
                        isBigger = false;
                    }
                }
                if (isBigger)
                {
                    Console.Write(array1[i] + " ");
                }

            }
        }
    }
}
