using System;
using System.Linq;

namespace From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                long[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                long greater = numbers.OrderByDescending(x => x).First();
                long sum = 0;

                while (greater != 0)
                {
                    sum += Math.Abs(greater % 10); // Взимаме последните числа, събираме и режем
                    greater /= 10;
                }
                Console.WriteLine(sum);
            }

            //int count = int.Parse(Console.ReadLine());
            //
            //for (int i = 0; i < count; i++)
            //{
            //    //var left = numbers[0].Sum(c => c - '0');       //Събира числата на масивчето вляво  
            //    //var right = numbers[1].Sum(c => c - '0'); 
            //    string[] numbers = Console.ReadLine().Split(' ');
            //
            //    long left = Math.Abs(long.Parse(numbers[0]));
            //    long right = Math.Abs(long.Parse(numbers[1]));
            //    double sumLeft = left.ToString().Sum(x => Char.GetNumericValue(x));
            //    double sumRight = right.ToString().Sum(x => Char.GetNumericValue(x));
            //
            //    if (sumLeft >= sumRight)
            //    {
            //        //int result = left.ToString().Sum(x => Convert.ToInt32(x));
            //        Console.WriteLine(sumLeft);
            //    }
            //
            //    else if (sumLeft <= sumRight)
            //    {
            //        //int result = right.ToString().Sum(x => Convert.ToInt32(x));;
            //        Console.WriteLine(sumRight);
            //    }
            //
            //}
        }
    }
}
