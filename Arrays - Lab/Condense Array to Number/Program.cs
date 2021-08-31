using System;
using System.Linq;


namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] newArray = new int[array.Length - 1];

            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < newArray.Length - i; j++)
                {
                    newArray[j] = array[j] + array[j + 1];
                }
                array = newArray;
            }
            Console.WriteLine(newArray[0]);
        }
    }
}
