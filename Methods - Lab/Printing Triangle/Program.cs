using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Triangle(num);

        }

        static void Line(int first, int last)
        {
            for (int i = first; i <= last; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        
        }

        static void Triangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Line(1, i);
            }

            for (int i = num - 1; i >= 1; i--)
            {
                Line(1, i);
            }
        }
    }
}
