using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double final = Math.Ceiling((double)people / capacity);
            Console.WriteLine(final);

        }
    }
}
