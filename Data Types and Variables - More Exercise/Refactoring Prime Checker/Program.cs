using System;

namespace Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool IsTrue = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        IsTrue = false;
                        break;
                    }
                }
                if (IsTrue)
                {
                    Console.WriteLine($"{i} -> true");
                }
                else if (!IsTrue)
                {
                    Console.WriteLine($"{i} -> false");
                }
                
            }

        }
    }
}
