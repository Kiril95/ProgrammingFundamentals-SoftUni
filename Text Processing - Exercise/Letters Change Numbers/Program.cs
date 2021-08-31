using System;
using System.Collections.Generic;
using System.Linq;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            //Dictionary<string, int> uppers = new Dictionary<string, int> { { "A", 1 },{ "B", 2 } }
            double total = 0;

            foreach (var item in input)
            {
                //var first = item.Take(1);
                var first = item.First();
                //var second = item.Skip(input.Count - 1);
                var last = item.Last();
                //var num = input.GetRange(first, second);
                var num = double.Parse(item.Substring(1, item.Length - 2));

                if (char.IsUpper(first))
                {
                    num /= first - 64;
                }
                else
                {
                    num *= first - 96;
                }

                if (char.IsUpper(last))
                {
                    num -= last - 64;
                }
                else
                {
                    num += last - 96;
                }
                total += num;

            }
            Console.WriteLine($"{total:f2}");

        }
    }
}
