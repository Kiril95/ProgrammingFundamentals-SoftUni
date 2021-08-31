using System;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"{GetTribonacci(i)} ");
            }

        }

        static int GetTribonacci(int num)
        {
            if (num <= 2)
            {
                return 1;
            }
            if (num == 3)
            {
                return 2;
            }
            else
            {
                return GetTribonacci(num - 1) + GetTribonacci(num - 2) + GetTribonacci(num - 3);
            }
        }
    }
}
