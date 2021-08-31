using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            var avg = numbers.Average();

            int[] result = numbers
                .Where(x => x > avg)
                .OrderByDescending(x => x)
                .Take(5)
                .ToArray();

            //int res = result.Count(x => x <= 5);

            if (result.Length <= 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }

        }
    }
}
