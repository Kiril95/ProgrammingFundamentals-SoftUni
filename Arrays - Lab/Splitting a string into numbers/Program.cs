using System;
using System.Linq;

namespace Splitting_a_string_into_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            
            
            string text = Console.ReadLine();
            string[] array1 = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int[] nums = new int[array1.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(array1[i]);
            }
        }
    }
}
