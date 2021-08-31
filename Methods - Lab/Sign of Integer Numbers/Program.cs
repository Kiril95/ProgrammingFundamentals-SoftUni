using System;
using System.Linq;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int num = int.Parse(Console.ReadLine());
        //    Sign(num);
        //
        //}
        //static void Sign(int n)   
        //{
        //    //int num = int.Parse(Console.ReadLine());
        //    if (n > 0)
        //    {
        //        Console.WriteLine($"The number {n} is positive.");
        //    }
        //    else if (n < 0)
        //    {
        //        Console.WriteLine($"The number {n} is negative.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The number {n} is zero.");
        //    }
        //    
        //}


        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Sign(num));

        }
        static string Sign(int n)  
        {
            string sign = "  ";
            if (n > 0)
            {
                sign = "positive";
            }
            else if (n < 0)
            {
                sign = "negative";
            }
            else
            {
                sign = "zero";
            }

            return $"The number {n} is {sign}.";
        }
    }
}
