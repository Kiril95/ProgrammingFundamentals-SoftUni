using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(first,second,third));

        }

        static int Sum(int first, int second, int third)
        {
            var result = first + second;
            return result - third;
        }
    }
}
