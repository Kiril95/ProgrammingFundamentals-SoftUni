using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(input));
        }

        static int Fibonacci(int num)
        {
            if (num == 0)
            {
                return 0;

            }
            if (num == 1)
            {
                return 1;
            }
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }

    }
}
