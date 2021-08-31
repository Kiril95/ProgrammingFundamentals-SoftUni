using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАПИСВАНЕ НА ЧИСЛА В МАСИВ
            int wagons = int.Parse(Console.ReadLine());

            int[] array1 = new int[wagons];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine(array1[i] + " ");              
            }

            var res = string.Join(' ', array1);
            int result = array1.Sum();
            Console.Write(res);
            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}
