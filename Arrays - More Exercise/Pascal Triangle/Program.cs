using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            if (rows == 1)
            {
                Console.WriteLine($"1");
            }
            else
            {
                Console.WriteLine($"1");  // Улесняваме си живота като директно си изписваме първите редове
                Console.WriteLine($"1 1");

                int[] current = { 1, 1 };

                for (int row = 3; row <= rows; row++)
                {

                    int[] num = new int[row];
                    num[0] = 1;

                    for (int col = 1; col < num.Length-1; col++)
                    {
                        num[col] = current[col - 1] + current[col];
                        num[col + 1] = 1;
                  
                    }
                    current = num;
                    Console.WriteLine(string.Join(" ", current));
                }
            }

      
        }
    }
}
