using System;

namespace Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Result(n1, n2, n3);
        }

        public static void Result(double n1, double n2, double n3)
        {          
            double[] numbers = { n1, n2, n3 };
            int negative = 0;
            int positive = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    negative++;
                }
                else if (numbers[i] > 0)
                {
                    positive++;
                }
            }

            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("zero");
            }

            else if (positive == 1 && negative == 2 || positive == 3)
            {
                Console.WriteLine("positive");
            }

            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
