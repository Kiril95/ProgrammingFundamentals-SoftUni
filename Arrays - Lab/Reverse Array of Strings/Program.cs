using System;
using System.Linq;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //double[] numbers = new double[array1.Length];  Преобразуване към числа
            
            var text = string.Join(' ', array1.Reverse());
            Console.WriteLine(text);

        }
    }
}
