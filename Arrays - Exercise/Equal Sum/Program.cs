using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int left = 0;
            int right = 0;
            
            for (int i = 0; i < array1.Length; i++)
            {
                left = array1.Take(i).Sum();
                right = array1.Skip(i + 1).Sum();
            
                if (left == right)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");

            //int[] array1 = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();
            //
            //int left = 0;
            //int right = 0;
            //
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    for (int j = i; j >= 0; j--)
            //    {
            //        left += array1[j];
            //    }
            //    for (int j = 0; j < array1.Length; j++)
            //    {
            //        right += array1[j];
            //    }
            //    if (left == right)
            //    {
            //        Console.WriteLine(i);
            //         return;
            //    }
            //}
            //Console.WriteLine("no");
        }
    }
}
