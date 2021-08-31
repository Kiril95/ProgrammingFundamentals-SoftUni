using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] array2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            //int sum = array1.Sum();  СЪБИРА ЧИСЛАТА В МАСИВА

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

                else if (array1.SequenceEqual(array2))
                {
                    foreach (var item in array1)
                    {
                        sum += item;
                    }
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    return;
                }
                             
            }
           
        }
    }
}
