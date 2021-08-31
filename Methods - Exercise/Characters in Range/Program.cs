using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            InRange(a, b);
        }

        static void InRange(char a, char b)
        {
            ///char[] array1 = new Char[a];
            
            int first = Math.Min(a, b);
            int last = Math.Max(a, b);

            for (int i = first + 1; i < last; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}
