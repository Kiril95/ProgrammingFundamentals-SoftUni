using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();

            var con = string.Concat(input1, input3, input2);

            Console.WriteLine(con);
        }
    }
}
