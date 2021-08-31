using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //var result = (dynamic)null; // ПРАЗЕН (ВАР) ЗА СПЕШНИ СЛУЧАЙ- ХОХО
            int rotations = int.Parse(Console.ReadLine());
          
            for (int i = 0; i < rotations; i++)
            {
                int test = array1[0];
                for (var j = 0; j < array1.Length - 1; j++)
                {
                    array1[j] = array1[j + 1];
                }
                array1[array1.Length - 1] = test;

            }                  
            Console.WriteLine(string.Join(' ', array1));
        }
    }
}
