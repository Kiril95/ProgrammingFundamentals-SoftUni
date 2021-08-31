using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string newNum = input.ToString();

            int sum = 0;
            for (int i = 0; i < newNum.Length; i++)
            {
                sum += int.Parse(Convert.ToString(newNum[i]));
            }
            Console.WriteLine(sum);

            // while (input > 0)
            // sum += input % 10;
            // input /= 10;
        }
    }
}
