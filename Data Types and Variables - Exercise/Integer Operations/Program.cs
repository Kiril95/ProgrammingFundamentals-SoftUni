using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());
            long third = long.Parse(Console.ReadLine());
            long fourth = long.Parse(Console.ReadLine());

            long final = (first + second) / third * fourth;
            Console.WriteLine(final);
        }
    }
}
