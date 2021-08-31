using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multi = int.Parse(Console.ReadLine());
            double sum = 0;

            if (multi > 10)
            {
                Console.WriteLine($"{num} X {multi} = {num * multi}");
                //break;
            }

            while (multi <= 10)
            {              
                sum = num * multi;
                Console.WriteLine($"{num} X {multi} = {sum}");
                multi++;            
            }
              
        }
    }    
}
