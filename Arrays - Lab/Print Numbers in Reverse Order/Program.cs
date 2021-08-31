using System;
using System.Linq;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            // Записване на числа в масив.

            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int [n];
            //
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int current = int.Parse(Console.ReadLine());
            //    numbers[i] = current;
            //}
            //
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = int.Parse(Console.ReadLine());
                numbers[i] = current;
            }

            var test = string.Join(" ", numbers.Reverse());
            Console.WriteLine(test);
        }
    }
}
