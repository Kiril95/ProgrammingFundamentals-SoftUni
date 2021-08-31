using System;
using System.Collections.Immutable;
using System.Linq;
using System.Collections.Generic;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            array1 = array1.OrderByDescending(x => x).ToArray();

            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
