using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
           // string[] array1 = Console.ReadLine()
           //     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
           //     .ToArray();
           //
           // string[] array2 = Console.ReadLine()
           //     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
           //     .ToArray();
           //
           // for (int i = 0; i < array1.Length; i++)
           // {
           //     for (int j = 0; j < array2.Length; j++)
           //     {
           //         if (array2[j] == array1[i])
           //         {
           //             Console.Write(array2[j] + " ");
           //         }
           //     }
           // }

            string[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] array2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var item in array2)
            {
                if (array1.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}
