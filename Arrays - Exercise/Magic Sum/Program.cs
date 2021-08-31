using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int magicNum = int.Parse(Console.ReadLine());
            //int sum = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = i + 1 ; j < array1.Length; j++)
                {
                    int sum = 0;
                    sum = array1[i] + array1[j];
                    if (sum == magicNum)
                    {
                        Console.Write($"{array1[i]} {array1[j]}");
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
