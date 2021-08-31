using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            bool isTrue = false;
            for (int i = 1; i <= input; i++)
            {               
                num = i;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                isTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isTrue}");
                sum = 0;
                //i = num;
            }

        }
    }
}
