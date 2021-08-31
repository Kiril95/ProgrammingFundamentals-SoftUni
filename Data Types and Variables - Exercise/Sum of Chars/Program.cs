using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            short input = short.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < input; i++)
            {
                string symbol = (Console.ReadLine());

                for (int j = 0; j < symbol.Length; j++)
                {
                    sum += (int)symbol[j];
                }
            }
            Console.WriteLine($"The sum equals: {sum}");



        }
    }
}
