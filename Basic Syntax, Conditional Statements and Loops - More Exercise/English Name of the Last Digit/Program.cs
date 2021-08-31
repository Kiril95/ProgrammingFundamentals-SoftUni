using System;
using System.Linq;

namespace English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            var getLast = numbers % 10;
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            if (getLast == 1)
            {
                Console.WriteLine("one");
            }
            else if (getLast == 2)
            {
                Console.WriteLine("two");
            }
            else if (getLast == 3)
            {
                Console.WriteLine("three");
            }
            else if (getLast == 4)
            {
                Console.WriteLine("four");
            }
            else if (getLast == 5)
            {
                Console.WriteLine("five");
            }
            else if (getLast == 6)
            {
                Console.WriteLine("six");
            }
            else if (getLast == 7)
            {
                Console.WriteLine("seven");
            }
            else if (getLast == 8)
            {
                Console.WriteLine("eight");
            }
            else if (getLast == 9)
            {
                Console.WriteLine("nine");
            }
            else if (getLast == 0)
            {
                Console.WriteLine("zero");
            }

        }

    }
}
