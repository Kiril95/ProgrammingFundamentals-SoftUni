using System;
using System.Linq;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            //double[] numbers = new double[array1.Length];  Преобразуване към числа

            var text = word.ToArray().Reverse();
            Console.WriteLine(string.Join("", text));

        }
    }
}
