using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int copy = n;
            int sum = 0;

            while (n > 0)
            {
                int factoriel = 1;
                double number = n % 10;
                n /= 10;

                for (int i = 2; i <= number; i++)
                {
                    factoriel *= i;
                }

                sum += factoriel;
            }
            if (sum == copy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
