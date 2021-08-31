using System;
using System.Collections.Generic;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine().TrimStart(new char[] { '0' });
            int num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int left = 0;
            int multy = 0;
            List<int> result = new List<int>();
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int current = num1[i] - '0';
                multy = current * num2;
                multy += left;
                result.Add(multy % 10);
                left = multy / 10;
            }
            if (left > 0)
            {
                result.Add(left);
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));


        }
    }
}
