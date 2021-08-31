using System;
using System.Numerics;

namespace Big_Factorial
{
    public class Big
    {

    }
    class Program
    {    
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger fac = 1;

            for (int i = 2; i <= num; i++)
            {
                fac *= i;
            }
            Console.WriteLine(fac);
        }
    }
}
