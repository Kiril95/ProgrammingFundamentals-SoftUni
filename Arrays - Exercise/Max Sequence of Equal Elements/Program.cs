using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = 1;
            int endNum = 0;
            int endCount = 1;
            int[] end = new int[endNum];

            for (int i = 1; i < array1.Length; i++)
            {
                if (array1[i] == array1[i - 1])
                {
                    count++;
                    if (count > endCount)
                    {
                        endCount = count;
                        endNum = array1[i];
                    }
                }

                else
                {
                    count = 1;
                }
            }

            for (int i = 0; i < endCount; i++)
            {
                Console.Write(string.Join(' ', endNum + " "));
            }         
        }
    }
}
